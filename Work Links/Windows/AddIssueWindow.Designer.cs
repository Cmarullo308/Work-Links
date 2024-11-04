namespace Work_Links.Windows {
    partial class AddIssueWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIssueWindow));
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.newIssueNameLabel = new System.Windows.Forms.Label();
            this.newIssueNameTextBox = new System.Windows.Forms.TextBox();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.seperatedByCommasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(301, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 96);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // newIssueNameLabel
            // 
            this.newIssueNameLabel.AutoSize = true;
            this.newIssueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIssueNameLabel.Location = new System.Drawing.Point(12, 8);
            this.newIssueNameLabel.Name = "newIssueNameLabel";
            this.newIssueNameLabel.Size = new System.Drawing.Size(87, 20);
            this.newIssueNameLabel.TabIndex = 4;
            this.newIssueNameLabel.Text = "Note name";
            // 
            // newIssueNameTextBox
            // 
            this.newIssueNameTextBox.Location = new System.Drawing.Point(116, 8);
            this.newIssueNameTextBox.Name = "newIssueNameTextBox";
            this.newIssueNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.newIssueNameTextBox.TabIndex = 0;
            this.newIssueNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newIssueNameTextBox_KeyDown);
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsLabel.Location = new System.Drawing.Point(12, 42);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(44, 20);
            this.tagsLabel.TabIndex = 5;
            this.tagsLabel.Text = "Tags";
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(116, 42);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(260, 20);
            this.tagsTextBox.TabIndex = 1;
            this.tagsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagsTextBox_KeyDown);
            // 
            // seperatedByCommasLabel
            // 
            this.seperatedByCommasLabel.AutoSize = true;
            this.seperatedByCommasLabel.Location = new System.Drawing.Point(187, 69);
            this.seperatedByCommasLabel.Name = "seperatedByCommasLabel";
            this.seperatedByCommasLabel.Size = new System.Drawing.Size(118, 13);
            this.seperatedByCommasLabel.TabIndex = 6;
            this.seperatedByCommasLabel.Text = "(Seperated by commas)";
            // 
            // AddIssueWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 131);
            this.Controls.Add(this.seperatedByCommasLabel);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.tagsTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newIssueNameLabel);
            this.Controls.Add(this.newIssueNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIssueWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Note";
            this.Load += new System.EventHandler(this.AddIssueWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label newIssueNameLabel;
        private System.Windows.Forms.TextBox newIssueNameTextBox;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Label seperatedByCommasLabel;
    }
}