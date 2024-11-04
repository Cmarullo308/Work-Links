namespace Work_Links.Windows {
    partial class EditNameWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNameWindow));
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.seperatedByCommasLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(220, 96);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameLabel.Location = new System.Drawing.Point(12, 8);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(84, 20);
            this.newNameLabel.TabIndex = 4;
            this.newNameLabel.Text = "New name";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(102, 8);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.newNameTextBox.TabIndex = 0;
            this.newNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newNameTextBox_KeyDown);
            // 
            // seperatedByCommasLabel
            // 
            this.seperatedByCommasLabel.AutoSize = true;
            this.seperatedByCommasLabel.Location = new System.Drawing.Point(180, 65);
            this.seperatedByCommasLabel.Name = "seperatedByCommasLabel";
            this.seperatedByCommasLabel.Size = new System.Drawing.Size(118, 13);
            this.seperatedByCommasLabel.TabIndex = 6;
            this.seperatedByCommasLabel.Text = "(Seperated by commas)";
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
            this.tagsTextBox.Location = new System.Drawing.Point(102, 42);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(274, 20);
            this.tagsTextBox.TabIndex = 1;
            this.tagsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagsTextBox_KeyDown);
            // 
            // EditNameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 131);
            this.Controls.Add(this.seperatedByCommasLabel);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.tagsTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.newNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditNameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Note";
            this.Load += new System.EventHandler(this.EditNameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label seperatedByCommasLabel;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.TextBox tagsTextBox;
    }
}