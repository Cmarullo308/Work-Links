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
    public partial class AreYouSureDialog : Form {
        public Choice Choice { get; private set; } = Choice.No;

        public AreYouSureDialog() {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e) {
            Choice = Choice.Yes;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e) {
            Choice = Choice.No;
            Close();
        }

        private void AreYouSureDialog_Load(object sender, EventArgs e) {

        }
    }
}
