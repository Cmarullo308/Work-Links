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
    public partial class SaveChangesWindow : Form {
        public Choice Result = Choice.Cancel;

        public SaveChangesWindow() {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e) {
            Result = Choice.Yes;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e) {
            Result = Choice.No;
            Close();
        }

        private void SaveChangesWindow_Load(object sender, EventArgs e) {

        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Result = Choice.Cancel;
            Close();
        }
    }
}
