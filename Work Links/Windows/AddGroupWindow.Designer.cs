namespace Work_Links.Windows {
    partial class AddGroupWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupWindow));
            this.newGroupNameTextBox = new System.Windows.Forms.TextBox();
            this.newGroupNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGroupNameTextBox
            // 
            this.newGroupNameTextBox.Location = new System.Drawing.Point(116, 9);
            this.newGroupNameTextBox.Name = "newGroupNameTextBox";
            this.newGroupNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.newGroupNameTextBox.TabIndex = 0;
            this.newGroupNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newGroupNameTextBox_KeyDown);
            // 
            // newGroupNameLabel
            // 
            this.newGroupNameLabel.AutoSize = true;
            this.newGroupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupNameLabel.Location = new System.Drawing.Point(12, 9);
            this.newGroupNameLabel.Name = "newGroupNameLabel";
            this.newGroupNameLabel.Size = new System.Drawing.Size(98, 20);
            this.newGroupNameLabel.TabIndex = 3;
            this.newGroupNameLabel.Text = "Group name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(116, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 38);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddGroupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 69);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newGroupNameLabel);
            this.Controls.Add(this.newGroupNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGroupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newGroupNameTextBox;
        private System.Windows.Forms.Label newGroupNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}