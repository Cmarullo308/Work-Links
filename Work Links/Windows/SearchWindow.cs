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
    public partial class SearchWindow : Form {
        public string noteNameSearch = "";
        public string noteContentsSearch = "";
        public List<string> tags = new List<string>();

        public SearchWindow() {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e) {
            noteNameSearch = noteNameTextBox.Text;
            noteContentsSearch = noteContainsTextBox.Text;

            if (!String.IsNullOrWhiteSpace(noteTagsTextBox.Text)) {
                tags = new List<string>(noteTagsTextBox.Text.Split(','));

                for (int i = 0; i < tags.Count; i++) {
                    tags[i] = tags[i].Trim();
                }
            }

            Close();
        }

        private void SearchWindow_Load(object sender, EventArgs e) {

        }

        public bool isBlank() {
            if (noteNameSearch.Equals("") && noteContentsSearch.Equals("") && tags.Count == 0) {
                return true;
            }

            return false;
        }

        public void clearWindow() {
            noteNameTextBox.Clear();
            noteContainsTextBox.Clear();
            noteTagsTextBox.Clear();
            noteNameSearch = "";
            noteContentsSearch = "";
            tags.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            noteNameTextBox.Clear();
            noteContainsTextBox.Clear();
            noteTagsTextBox.Clear();
        }

        public bool nameQueryEmpty() {
            return String.IsNullOrWhiteSpace(noteNameSearch);
        }

        public bool contentsQueryEmpty() {
            return String.IsNullOrWhiteSpace(noteContentsSearch);
        }

        public bool tagsQueryEmpty() {
            if(tags.Count == 0) {
                return true;
            }

            return false;
        }

        private void noteNameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchButton.PerformClick();
            }
        }

        private void noteContainsTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchButton.PerformClick();
            }
        }

        private void noteTagsTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchButton.PerformClick();
            }
        }
    }
}
