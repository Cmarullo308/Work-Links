using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Links.Windows {
    public partial class EditNameWindow : Form {
        public bool saveButtonClicked { get; private set; } = false;
        public string NewName {
            get {
                return newNameTextBox.Text;
            }
        }

        public List<string> tags;

        public EditNameWindow(Group group) {
            InitializeComponent();

            this.Text = "Edit group name";
            this.newNameTextBox.Text = group.Name;
        }

        public EditNameWindow(Issue issue) {
            InitializeComponent();

            this.Text = "Edit issue name";
            this.newNameTextBox.Text = issue.name;

            tagsTextBox.Text = changeTagsListToString(issue);
        }

        private string changeTagsListToString(Issue issue) {
            if (issue.tags == null) {
                return "";
            }

            string tags = "";

            foreach (string tag in issue.tags) {
                tags += tag + ",";
            }

            tags = tags.Substring(0, tags.Length - 1);

            return tags;
        }

        private void EditNameWindow_Load(object sender, EventArgs e) {

        }

        private void saveButton_Click(object sender, EventArgs e) {
            if (!String.IsNullOrWhiteSpace(tagsTextBox.Text)) {
                tags = new List<string>(tagsTextBox.Text.Split(','));
            }

            if (tags != null) {
                for (int i = 0; i < tags.Count; i++) {
                    tags[i] = tags[i].Trim();
                }
            }

            saveButtonClicked = true;
            Close();
        }

        private void newNameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                saveButton.PerformClick();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void tagsTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                saveButton.PerformClick();
            }
        }
    }
}
