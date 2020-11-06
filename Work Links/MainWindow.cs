using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Links.Windows;

namespace Work_Links {
    public partial class MainWindow : Form {
        public GroupData groupData = new GroupData();
        private bool unsavedData = false;
        private bool StartupComplete = false;
        private bool switchingGroupOrIssue = false;
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
                groupData.addGroup(new Group(addGroupWindow.NewGroupName));
                UnsavedData = true;
                groupData.sortGroups();
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (groupsListBox.SelectedIndex < 0) {
                return;
            }

            switchingGroupOrIssue = true;

            if (currentIssue != null) {
                currentIssue.textBoxText = issueTextBox.Text;
            }

            //currentIssue = null;

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
                group.addIssue(new Issue(addIssueWindow.NewIssueName));
                UnsavedData = true;
            }
        }

        private void issueListBox_SelectedIndexChanged(object sender, EventArgs e) {
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
            UnsavedData = true;
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

            System.Diagnostics.Process.Start(currentIssue.links[index].path);
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
            if(issueListBox.SelectedIndex < 0) {
                return;
            }

            AreYouSureDialog areYouSureDialog = new AreYouSureDialog();
            areYouSureDialog.ShowDialog();


            if (areYouSureDialog.Choice == Choice.Yes) {
                getSelectedGroup().issues.RemoveAt(issueListBox.SelectedIndex);
                UnsavedData = true;
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
            Issue issue = group.issues[issueListBox.SelectedIndex];

            EditNameWindow editNameWindow = new EditNameWindow(issue);
            editNameWindow.ShowDialog();

            if (editNameWindow.saveButtonClicked) {
                issue.name = editNameWindow.NewName;
                issueListBox.DataSource = null;
                issueListBox.DataSource = getSelectedGroup().issues;
                group.sortIssues();
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
            currentIssue.locked = lockedCheckBox.Checked;
            updateIssueInfo();
            UnsavedData = true;
        }
    }
}
