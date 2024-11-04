using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Work_Links.Windows {
    public partial class EditLinkWindow : Form {
        public bool SaveButtonClicked { get; private set; } = false;
        readonly CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        public string NewName {
            get {
                return nameTextBox.Text;
            }
        }
        public string NewPath {
            get {
                return pathTextBox.Text;
            }
        }

        public EditLinkWindow(Link link) {
            InitializeComponent();

            nameTextBox.Text = link.name;
            pathTextBox.Text = link.path;
        }

        private void EditLinkWindow_Load(object sender, EventArgs e) {

        }

        private void saveButton_Click(object sender, EventArgs e) {
            SaveButtonClicked = true;
            Close();
        }

        private void selectFileButton_Click(object sender, EventArgs e) {
            String directory = "C:\\";

            dialog.InitialDirectory = directory;
            dialog.IsFolderPicker = false;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                pathTextBox.Text = dialog.FileName;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                saveButton.PerformClick();
            }
        }

        private void pathTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                saveButton.PerformClick();
            }
        }
    }
}
