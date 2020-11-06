namespace Work_Links.Windows {
    partial class AlreadyAnInstanceWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlreadyAnInstanceWindow));
            this.okButton = new System.Windows.Forms.Button();
            this.alreadyAnInstanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(129, 77);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // alreadyAnInstanceLabel
            // 
            this.alreadyAnInstanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyAnInstanceLabel.Location = new System.Drawing.Point(12, 11);
            this.alreadyAnInstanceLabel.Name = "alreadyAnInstanceLabel";
            this.alreadyAnInstanceLabel.Size = new System.Drawing.Size(308, 60);
            this.alreadyAnInstanceLabel.TabIndex = 2;
            this.alreadyAnInstanceLabel.Text = "An instance of Work Links is already running";
            this.alreadyAnInstanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlreadyAnInstanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 110);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.alreadyAnInstanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlreadyAnInstanceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Work Links is already running";
            this.Load += new System.EventHandler(this.AlreadyAnInstanceWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label alreadyAnInstanceLabel;
    }
}