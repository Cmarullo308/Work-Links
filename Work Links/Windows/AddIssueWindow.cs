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
    public partial class AddIssueWindow : Form {
        public bool okPressed { get; private set; } = false;
        public string NewIssueName {
            get {
                return newIssueNameTextBox.Text;
            }

            private set {

            }
        }

        public AddIssueWindow() {
            InitializeComponent();
        }

        private void AddIssueWindow_Load(object sender, EventArgs e) {

        }

        private void addButton_Click(object sender, EventArgs e) {
            okPressed = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void newIssueNameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                addButton.PerformClick();
            }
        }
    }
}
