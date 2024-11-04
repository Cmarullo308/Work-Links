namespace Work_Links.Windows {
    partial class SearchWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindow));
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.noteContainsLabel = new System.Windows.Forms.Label();
            this.noteContainsTextBox = new System.Windows.Forms.TextBox();
            this.noteTagsTextBox = new System.Windows.Forms.TextBox();
            this.noteTagsLabel = new System.Windows.Forms.Label();
            this.seperatedByCommasLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Location = new System.Drawing.Point(12, 21);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(61, 13);
            this.noteNameLabel.TabIndex = 7;
            this.noteNameLabel.Text = "Note Name";
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteNameTextBox.Location = new System.Drawing.Point(95, 17);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.noteNameTextBox.TabIndex = 0;
            this.noteNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteNameTextBox_KeyDown);
            // 
            // noteContainsLabel
            // 
            this.noteContainsLabel.AutoSize = true;
            this.noteContainsLabel.Location = new System.Drawing.Point(12, 56);
            this.noteContainsLabel.Name = "noteContainsLabel";
            this.noteContainsLabel.Size = new System.Drawing.Size(74, 13);
            this.noteContainsLabel.TabIndex = 8;
            this.noteContainsLabel.Text = "Note Contains";
            // 
            // noteContainsTextBox
            // 
            this.noteContainsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteContainsTextBox.Location = new System.Drawing.Point(95, 52);
            this.noteContainsTextBox.Name = "noteContainsTextBox";
            this.noteContainsTextBox.Size = new System.Drawing.Size(236, 20);
            this.noteContainsTextBox.TabIndex = 1;
            this.noteContainsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteContainsTextBox_KeyDown);
            // 
            // noteTagsTextBox
            // 
            this.noteTagsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTagsTextBox.Location = new System.Drawing.Point(95, 87);
            this.noteTagsTextBox.Name = "noteTagsTextBox";
            this.noteTagsTextBox.Size = new System.Drawing.Size(236, 20);
            this.noteTagsTextBox.TabIndex = 3;
            this.noteTagsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteTagsTextBox_KeyDown);
            // 
            // noteTagsLabel
            // 
            this.noteTagsLabel.AutoSize = true;
            this.noteTagsLabel.Location = new System.Drawing.Point(12, 91);
            this.noteTagsLabel.Name = "noteTagsLabel";
            this.noteTagsLabel.Size = new System.Drawing.Size(57, 13);
            this.noteTagsLabel.TabIndex = 9;
            this.noteTagsLabel.Text = "Note Tags";
            // 
            // seperatedByCommasLabel
            // 
            this.seperatedByCommasLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.seperatedByCommasLabel.AutoSize = true;
            this.seperatedByCommasLabel.Location = new System.Drawing.Point(154, 110);
            this.seperatedByCommasLabel.Name = "seperatedByCommasLabel";
            this.seperatedByCommasLabel.Size = new System.Drawing.Size(118, 13);
            this.seperatedByCommasLabel.TabIndex = 4;
            this.seperatedByCommasLabel.Text = "(Seperated by commas)";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Location = new System.Drawing.Point(157, 140);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 175);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.seperatedByCommasLabel);
            this.Controls.Add(this.noteTagsTextBox);
            this.Controls.Add(this.noteTagsLabel);
            this.Controls.Add(this.noteContainsTextBox);
            this.Controls.Add(this.noteContainsLabel);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.noteNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.Label noteContainsLabel;
        private System.Windows.Forms.TextBox noteContainsTextBox;
        private System.Windows.Forms.TextBox noteTagsTextBox;
        private System.Windows.Forms.Label noteTagsLabel;
        private System.Windows.Forms.Label seperatedByCommasLabel;
        private System.Windows.Forms.Button searchButton;
    }
}