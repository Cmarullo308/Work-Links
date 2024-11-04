using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class AddLinkWindow : Form {
        readonly CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        public bool okClicked { get; private set; } = false;

        public string LinkPath {
            get {
                return pathTextBox.Text;
            }
        }

        public string LinkName {
            get {
                return nameTextBox.Text;
            }
        }

        public AddLinkWindow() {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e) {
            String directory = "C:\\";

            dialog.InitialDirectory = directory;
            dialog.IsFolderPicker = false;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                okClicked = true;
                pathTextBox.Text = dialog.FileName;
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            okClicked = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                addButton.PerformClick();
            }
        }

        private void pathTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                addButton.PerformClick();
            }
        }
    }
}
