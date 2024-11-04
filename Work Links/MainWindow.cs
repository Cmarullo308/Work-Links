using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Links.Windows;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Work_Links {
    public partial class MainWindow : Form {
        public GroupData groupData = new GroupData();
        private bool unsavedData = false;
        private bool StartupComplete = false;
        private bool switchingGroupOrIssue = false;
        private bool filtered = false;
        private bool currentlyFiltering = false;
        private BindingList<Issue> filteredIssues = new BindingList<Issue>();
        private SearchWindow searchWindow = new SearchWindow();


        public bool UnsavedData {
            get {
                return unsavedData;
            }

            set {
                if (StartupComplete && !switchingGroupOrIssue) {
                    unsavedData = value;
                    unsavedDataChanged();
                }
            }
        }

        public bool Filtered {
            get {
                return filtered;
            }

            set {
                filtered = value;
                clearSearchButton.Visible = value;
            }
        }

        Issue currentIssue;

        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            Program.loadFile();

            groupsListBox.DataSource = groupData.getGroups();
            StartupComplete = true;
        }

        private void unsavedDataChanged() {
            Text = UnsavedData ? "*Work Links" : "Work Links";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void addGroupButton_Click(object sender, EventArgs e) {
            AddGroupWindow addGroupWindow = new AddGroupWindow();
            addGroupWindow.ShowDialog();

            if (addGroupWindow.okPressed) {
                Group newGroup = new Group(addGroupWindow.NewGroupName);
                groupData.addGroup(newGroup);
                UnsavedData = true;
                groupData.sortGroups();

                groupsListBox.SelectedIndex = getGroupIndexByIDNumber(newGroup.idNumber);
            }
        }

        private int getGroupIndexByIDNumber(Guid idNumber) {
            BindingList<Group> groups = groupData.getGroups();

            for (int i = 0; i < groups.Count; i++) {
                if (groups[i].idNumber == idNumber) {
                    groupsListBox.SelectedIndex = i;
                    return i;
                }
            }

            return -1;
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (groupsListBox.SelectedIndex < 0) {
                return;
            }

            switchingGroupOrIssue = true;

            clearSearches();

            if (currentIssue != null) {
                currentIssue.textBoxText = issueTextBox.Text;
            }

            searchTextBox.Clear();

            Group group = groupData.groupFromIndex(groupsListBox.SelectedIndex);

            issueListBox.DataSource = group.issues;

            if (group.issues.Count < 1) {
                currentIssue = null;
                updateIssueInfo();
                //issueTextBox.Text = "";
                //issueTextBox.ReadOnly = true;
                //issueNameLabel.Visible = false;
                //linksListBox.DataSource = null;
            }

            switchingGroupOrIssue = false;
        }

        private void addIssueButton_Click(object sender, EventArgs e) {
            Group group = groupData.groupFromIndex(groupsListBox.SelectedIndex);

            if (group == null) {
                return;
            }

            AddIssueWindow addIssueWindow = new AddIssueWindow();
            addIssueWindow.ShowDialog();

            if (addIssueWindow.okPressed) {
                Issue issue = new Issue(addIssueWindow.NewIssueName, addIssueWindow.tags);
                group.addIssue(issue);
                UnsavedData = true;
                selectIssue(group, issue.idNumber);
            }
        }

        private void selectIssue(Group group, Guid idNumber) {
            if (filtered) {
                for(int i = 0; i < filteredIssues.Count; i++) {
                    if(filteredIssues.ElementAt(i).idNumber == idNumber) {
                        issueListBox.SelectedIndex = i;
                        return;
                    }
                }
            } else {
                for (int i = 0; i < group.issues.Count; i++) {
                    if (group.issues.ElementAt(i).idNumber == idNumber) {
                        issueListBox.SelectedIndex = i; //Here
                        return;
                    }
                }
            }
        }

        private void issueListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (!Filtered) {
                switchingGroupOrIssue = true;

                if (currentIssue != null) {
                    currentIssue.textBoxText = issueTextBox.Text;
                }

                Group group = groupData.groupFromIndex(groupsListBox.SelectedIndex);

                if (group != null && issueListBox.SelectedIndex >= 0) {
                    currentIssue = group.issues[issueListBox.SelectedIndex];
                    issueNameLabel.Visible = true;
                } else {
                    currentIssue = null;
                }

                updateIssueInfo();

                switchingGroupOrIssue = false;
            } else {
                switchingGroupOrIssue = true;

                if (currentIssue != null) {
                    currentIssue.textBoxText = issueTextBox.Text;
                }

                if (issueListBox.SelectedIndex >= 0) {
                    currentIssue = filteredIssues[issueListBox.SelectedIndex];
                    issueNameLabel.Visible = true;
                } else {
                    currentIssue = null;
                }

                updateIssueInfo();

                switchingGroupOrIssue = false;
            }

            copiedLinkToClipboardLabel.Visible = false;
        }

        public void updateIssueInfo() {
            if (currentIssue != null) {
                lockedCheckBox.Checked = currentIssue.locked;
                issueNameLabel.Text = currentIssue.name;
                issueTextBox.Text = currentIssue.textBoxText;
                issueTextBox.ReadOnly = currentIssue.locked;
                linksListBox.DataSource = currentIssue.links;

                addLinkButton.Visible = !currentIssue.locked;
                removeLinkButton.Visible = !currentIssue.locked;
                editLinkButton.Visible = !currentIssue.locked;
                lockedCheckBox.Visible = true;
            } else {
                issueNameLabel.Visible = false;
                issueTextBox.Text = "";
                issueTextBox.ReadOnly = true;
                linksListBox.DataSource = null;

                addLinkButton.Visible = false;
                removeLinkButton.Visible = false;
                editLinkButton.Visible = false;
                lockedCheckBox.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (!currentlyFiltering) {
                UnsavedData = true;
            }
        }

        private void addLinkButton_Click(object sender, EventArgs e) {
            AddLinkWindow addLinkWindow = new AddLinkWindow();
            addLinkWindow.ShowDialog();

            if (addLinkWindow.okClicked) {
                currentIssue.links.Add(new Link(addLinkWindow.LinkName, addLinkWindow.LinkPath));
                currentIssue.sortLinks();
                UnsavedData = true;
            }
        }

        private void linksListBox_DoubleClick(object sender, EventArgs e) {
            int index = linksListBox.SelectedIndex;

            if (index < 0) {
                return;
            }

            //Error messege if invalid or null link
            try {
                System.Diagnostics.Process.Start(currentIssue.links[index].path);
            } catch (System.ComponentModel.Win32Exception) {
                MessageBox.Show("Invalid or Null link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (currentIssue != null) {
                currentIssue.textBoxText = issueTextBox.Text;
            }

            Program.saveData();
            UnsavedData = false;
        }

        private void removeGroupButton_Click(object sender, EventArgs e) {
            if (groupsListBox.SelectedIndex < 0) {
                return;
            }

            AreYouSureDialog areYouSureDialog = new AreYouSureDialog();
            areYouSureDialog.ShowDialog();

            if (areYouSureDialog.Choice == Choice.Yes) {
                groupData.removeGroupAt(groupsListBox.SelectedIndex);

                if (groupsListBox.Items.Count < 1) {
                    issueListBox.DataSource = null;
                }

                UnsavedData = true;
            }
        }

        private void removeIssueButton_Click(object sender, EventArgs e) {
            if (issueListBox.SelectedIndex < 0) {
                return;
            }

            AreYouSureDialog areYouSureDialog = new AreYouSureDialog();
            areYouSureDialog.ShowDialog();


            if (areYouSureDialog.Choice == Choice.Yes) {
                if (Filtered) {
                    deleteIssueByIDNumber(getSelectedGroup(), filteredIssues.ElementAt(issueListBox.SelectedIndex).idNumber);
                    filteredIssues.RemoveAt(issueListBox.SelectedIndex);
                } else {
                    getSelectedGroup().issues.RemoveAt(issueListBox.SelectedIndex);
                }

                int issueBoxSelectedIndex = issueListBox.SelectedIndex;
                issueListBox.ClearSelected();
                issueListBox.SelectedIndex = issueBoxSelectedIndex;

                UnsavedData = true;
            }
        }

        private void deleteIssueByIDNumber(Group group, Guid idNumber) {
            for (int i = 0; i < group.issues.Count; i++) {
                if (group.issues[i].idNumber == idNumber) {
                    group.issues.RemoveAt(i);
                    return;
                }
            }
        }

        public Group getSelectedGroup() {
            return groupData.groupFromIndex(groupsListBox.SelectedIndex);
        }

        private void removeLinkButton_Click(object sender, EventArgs e) {
            if (linksListBox.SelectedIndex < 0) {
                return;
            }

            AreYouSureDialog areYouSureDialog = new AreYouSureDialog();
            areYouSureDialog.ShowDialog();

            if (areYouSureDialog.Choice == Choice.Yes) {
                currentIssue.links.RemoveAt(linksListBox.SelectedIndex);
                UnsavedData = true;
            }
        }

        private void editGroupButton_Click(object sender, EventArgs e) {
            if (groupsListBox.SelectedIndex < 0) {
                return;
            }

            Group group = getSelectedGroup();

            EditNameWindow editNameWindow = new EditNameWindow(group);
            editNameWindow.ShowDialog();

            if (editNameWindow.saveButtonClicked) {
                group.Name = editNameWindow.NewName;
                groupsListBox.DataSource = null;
                groupsListBox.DataSource = groupData.getGroups();
                groupData.sortGroups();
                UnsavedData = true;
            }
        }

        private void editIssueButton_Click(object sender, EventArgs e) {
            if (issueListBox.SelectedIndex < 0) {
                return;
            }

            Group group = getSelectedGroup();
            Issue issue;

            if (Filtered) {
                issue = filteredIssues[issueListBox.SelectedIndex];
            } else {
                issue = group.issues[issueListBox.SelectedIndex];
            }

            EditNameWindow editNameWindow = new EditNameWindow(issue);
            editNameWindow.ShowDialog();

            if (editNameWindow.saveButtonClicked) {
                issue.name = editNameWindow.NewName;
                issue.tags = editNameWindow.tags;
                issueListBox.DataSource = null;
                if (Filtered) {
                    issueListBox.DataSource = filteredIssues;
                } else {
                    issueListBox.DataSource = getSelectedGroup().issues;
                }
                group.sortIssues();
                selectIssue(group, issue.idNumber);
                UnsavedData = true;
            }
        }

        private void editLinkButton_Click(object sender, EventArgs e) {
            if (linksListBox.SelectedIndex < 0) {
                return;
            }

            Link link = currentIssue.links[linksListBox.SelectedIndex];

            EditLinkWindow editLinkWindow = new EditLinkWindow(link);
            editLinkWindow.ShowDialog();

            if (editLinkWindow.SaveButtonClicked) {
                link.name = editLinkWindow.NewName;
                link.path = editLinkWindow.NewPath;
                linksListBox.DataSource = null;
                linksListBox.DataSource = currentIssue.links;
                UnsavedData = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if (UnsavedData) {
                e.Cancel = true;
                SaveChangesWindow saveChangesWindow = new SaveChangesWindow();
                saveChangesWindow.ShowDialog();

                if (saveChangesWindow.Result == Choice.Yes) {
                    if (currentIssue != null) {
                        currentIssue.textBoxText = issueTextBox.Text;
                    }
                    Program.saveData();
                    UnsavedData = false;
                    Application.Exit();
                } else if (saveChangesWindow.Result == Choice.No) {
                    UnsavedData = false;
                    Application.Exit();
                }
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
            new AboutWindow().ShowDialog();
        }

        private void lockedCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (switchingGroupOrIssue) {
                return;
            }

            currentIssue.textBoxText = issueTextBox.Text;
            currentIssue.locked = lockedCheckBox.Checked;
            updateIssueInfo();
            UnsavedData = true;
        }

        private void searchButton_Click(object sender, EventArgs e) {
            searchWindow.ShowDialog();
            if (!searchWindow.isBlank()) {
                searchTextBox.Enabled = false;
                searchTextBox.Text = "(Advanced Search)";
                Filtered = true;

                doAdvancedSearch();
                issueListBox.DataSource = filteredIssues;
            } else {
                issueListBox.DataSource = getSelectedGroup().issues;
                clearSearches();
            }
        }

        private void doAdvancedSearch() {
            Group group = getSelectedGroup();

            string nameToSearch = searchWindow.noteNameSearch.ToLower();
            string contentsToSearch = searchWindow.noteContentsSearch.ToLower();

            filteredIssues = new BindingList<Issue>(group.issues.Where(issue =>
                issue.name.ToLower().Contains(nameToSearch) &&
                issue.textBoxText.ToLower().Contains(contentsToSearch) &&
                (!searchWindow.tags.Any() || issue.tags != null && (searchWindow.tags.All(tag => issue.tags.Contains(tag, StringComparer.OrdinalIgnoreCase))))
            ).ToList());
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            if (!searchTextBox.Enabled) {
                return;
            }

            string searchFor = searchTextBox.Text;
            Group group = getSelectedGroup();

            if (searchFor.Equals("")) {
                Filtered = false;
                issueListBox.DataSource = group.issues;
                return;
            }

            filteredIssues.Clear();

            currentlyFiltering = true;

            foreach (Issue issue in group.issues) {
                if (issue.name.ToLower().Contains(searchFor.ToLower())) {
                    filteredIssues.Add(issue);
                }
            }

            Filtered = true;
            issueListBox.DataSource = filteredIssues;
            if (issueListBox.SelectedIndex >= 0) {
                currentIssue = filteredIssues[issueListBox.SelectedIndex];
                updateIssueInfo();
            }

            currentlyFiltering = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {

            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e) {
            clearSearches();
        }

        private void clearSearches() {
            Filtered = false;
            issueListBox.DataSource = getSelectedGroup().issues;
            searchTextBox.Clear();
            searchTextBox.Enabled = true;
            searchWindow.clearWindow();
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e) {
            int index = linksListBox.SelectedIndex;

            if(index < 0) {
                return;
            }

            System.Windows.Forms.Clipboard.SetText(currentIssue.links[index].path);
            copiedLinkToClipboardLabel.Visible = true;
        }

        private void linksListBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void linksListBox_SelectedIndexChanged_1(object sender, EventArgs e) {
            copiedLinkToClipboardLabel.Visible = false;
        }
    }
}
