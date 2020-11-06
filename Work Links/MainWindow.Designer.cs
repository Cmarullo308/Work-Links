namespace Work_Links {
    partial class MainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issueListBox = new System.Windows.Forms.ListBox();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.issueNameLabel = new System.Windows.Forms.Label();
            this.linksListBox = new System.Windows.Forms.ListBox();
            this.lockedCheckBox = new System.Windows.Forms.CheckBox();
            this.editLinkButton = new System.Windows.Forms.Button();
            this.removeLinkButton = new System.Windows.Forms.Button();
            this.addLinkButton = new System.Windows.Forms.Button();
            this.editIssueButton = new System.Windows.Forms.Button();
            this.removeIssueButton = new System.Windows.Forms.Button();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.HorizontalScrollbar = true;
            this.groupsListBox.ItemHeight = 25;
            this.groupsListBox.Location = new System.Drawing.Point(12, 67);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(266, 654);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // issueListBox
            // 
            this.issueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.issueListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueListBox.FormattingEnabled = true;
            this.issueListBox.HorizontalScrollbar = true;
            this.issueListBox.ItemHeight = 25;
            this.issueListBox.Location = new System.Drawing.Point(284, 67);
            this.issueListBox.Name = "issueListBox";
            this.issueListBox.Size = new System.Drawing.Size(362, 654);
            this.issueListBox.TabIndex = 2;
            this.issueListBox.SelectedIndexChanged += new System.EventHandler(this.issueListBox_SelectedIndexChanged);
            // 
            // issueTextBox
            // 
            this.issueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueTextBox.Location = new System.Drawing.Point(654, 179);
            this.issueTextBox.Multiline = true;
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issueTextBox.Size = new System.Drawing.Size(590, 543);
            this.issueTextBox.TabIndex = 4;
            this.issueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // issueNameLabel
            // 
            this.issueNameLabel.AutoSize = true;
            this.issueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNameLabel.Location = new System.Drawing.Point(650, 37);
            this.issueNameLabel.Name = "issueNameLabel";
            this.issueNameLabel.Size = new System.Drawing.Size(110, 24);
            this.issueNameLabel.TabIndex = 13;
            this.issueNameLabel.Text = "Issue Name";
            // 
            // linksListBox
            // 
            this.linksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksListBox.FormattingEnabled = true;
            this.linksListBox.ItemHeight = 24;
            this.linksListBox.Location = new System.Drawing.Point(654, 97);
            this.linksListBox.Name = "linksListBox";
            this.linksListBox.Size = new System.Drawing.Size(590, 76);
            this.linksListBox.TabIndex = 15;
            this.linksListBox.DoubleClick += new System.EventHandler(this.linksListBox_DoubleClick);
            // 
            // lockedCheckBox
            // 
            this.lockedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lockedCheckBox.AutoSize = true;
            this.lockedCheckBox.Location = new System.Drawing.Point(1182, 72);
            this.lockedCheckBox.Name = "lockedCheckBox";
            this.lockedCheckBox.Size = new System.Drawing.Size(62, 17);
            this.lockedCheckBox.TabIndex = 16;
            this.lockedCheckBox.Text = "Locked";
            this.lockedCheckBox.UseVisualStyleBackColor = true;
            this.lockedCheckBox.CheckedChanged += new System.EventHandler(this.lockedCheckBox_CheckedChanged);
            // 
            // editLinkButton
            // 
            this.editLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Pencil;
            this.editLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editLinkButton.FlatAppearance.BorderSize = 0;
            this.editLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLinkButton.Location = new System.Drawing.Point(704, 70);
            this.editLinkButton.Name = "editLinkButton";
            this.editLinkButton.Size = new System.Drawing.Size(20, 20);
            this.editLinkButton.TabIndex = 14;
            this.editLinkButton.UseVisualStyleBackColor = true;
            this.editLinkButton.Click += new System.EventHandler(this.editLinkButton_Click);
            // 
            // removeLinkButton
            // 
            this.removeLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Minus1;
            this.removeLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeLinkButton.FlatAppearance.BorderSize = 0;
            this.removeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLinkButton.Location = new System.Drawing.Point(678, 70);
            this.removeLinkButton.Name = "removeLinkButton";
            this.removeLinkButton.Size = new System.Drawing.Size(20, 20);
            this.removeLinkButton.TabIndex = 12;
            this.removeLinkButton.UseVisualStyleBackColor = true;
            this.removeLinkButton.Click += new System.EventHandler(this.removeLinkButton_Click);
            // 
            // addLinkButton
            // 
            this.addLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Plus1;
            this.addLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addLinkButton.FlatAppearance.BorderSize = 0;
            this.addLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLinkButton.Location = new System.Drawing.Point(652, 70);
            this.addLinkButton.Name = "addLinkButton";
            this.addLinkButton.Size = new System.Drawing.Size(20, 20);
            this.addLinkButton.TabIndex = 11;
            this.addLinkButton.UseVisualStyleBackColor = true;
            this.addLinkButton.Click += new System.EventHandler(this.addLinkButton_Click);
            // 
            // editIssueButton
            // 
            this.editIssueButton.BackgroundImage = global::Work_Links.Properties.Resources.Pencil;
            this.editIssueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editIssueButton.FlatAppearance.BorderSize = 0;
            this.editIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editIssueButton.Location = new System.Drawing.Point(350, 34);
            this.editIssueButton.Name = "editIssueButton";
            this.editIssueButton.Size = new System.Drawing.Size(27, 27);
            this.editIssueButton.TabIndex = 10;
            this.editIssueButton.UseVisualStyleBackColor = true;
            this.editIssueButton.Click += new System.EventHandler(this.editIssueButton_Click);
            // 
            // removeIssueButton
            // 
            this.removeIssueButton.BackgroundImage = global::Work_Links.Properties.Resources.Minus1;
            this.removeIssueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeIssueButton.FlatAppearance.BorderSize = 0;
            this.removeIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeIssueButton.Location = new System.Drawing.Point(317, 34);
            this.removeIssueButton.Name = "removeIssueButton";
            this.removeIssueButton.Size = new System.Drawing.Size(27, 27);
            this.removeIssueButton.TabIndex = 9;
            this.removeIssueButton.UseVisualStyleBackColor = true;
            this.removeIssueButton.Click += new System.EventHandler(this.removeIssueButton_Click);
            // 
            // addIssueButton
            // 
            this.addIssueButton.BackgroundImage = global::Work_Links.Properties.Resources.Plus1;
            this.addIssueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addIssueButton.FlatAppearance.BorderSize = 0;
            this.addIssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIssueButton.Location = new System.Drawing.Point(284, 34);
            this.addIssueButton.Name = "addIssueButton";
            this.addIssueButton.Size = new System.Drawing.Size(27, 27);
            this.addIssueButton.TabIndex = 8;
            this.addIssueButton.UseVisualStyleBackColor = true;
            this.addIssueButton.Click += new System.EventHandler(this.addIssueButton_Click);
            // 
            // editGroupButton
            // 
            this.editGroupButton.BackgroundImage = global::Work_Links.Properties.Resources.Pencil;
            this.editGroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editGroupButton.FlatAppearance.BorderSize = 0;
            this.editGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGroupButton.Location = new System.Drawing.Point(78, 34);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(27, 27);
            this.editGroupButton.TabIndex = 7;
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.BackgroundImage = global::Work_Links.Properties.Resources.Minus1;
            this.removeGroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeGroupButton.FlatAppearance.BorderSize = 0;
            this.removeGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGroupButton.Location = new System.Drawing.Point(45, 34);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(27, 27);
            this.removeGroupButton.TabIndex = 6;
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.BackgroundImage = global::Work_Links.Properties.Resources.Plus1;
            this.addGroupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addGroupButton.FlatAppearance.BorderSize = 0;
            this.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupButton.Location = new System.Drawing.Point(12, 34);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(27, 27);
            this.addGroupButton.TabIndex = 5;
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 736);
            this.Controls.Add(this.lockedCheckBox);
            this.Controls.Add(this.linksListBox);
            this.Controls.Add(this.editLinkButton);
            this.Controls.Add(this.issueNameLabel);
            this.Controls.Add(this.removeLinkButton);
            this.Controls.Add(this.addLinkButton);
            this.Controls.Add(this.editIssueButton);
            this.Controls.Add(this.removeIssueButton);
            this.Controls.Add(this.addIssueButton);
            this.Controls.Add(this.editGroupButton);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.issueTextBox);
            this.Controls.Add(this.issueListBox);
            this.Controls.Add(this.groupsListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1273, 775);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Links";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox issueListBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.Button editIssueButton;
        private System.Windows.Forms.Button removeIssueButton;
        private System.Windows.Forms.Button addIssueButton;
        private System.Windows.Forms.Button addLinkButton;
        private System.Windows.Forms.Button removeLinkButton;
        private System.Windows.Forms.Label issueNameLabel;
        private System.Windows.Forms.Button editLinkButton;
        private System.Windows.Forms.ListBox linksListBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.CheckBox lockedCheckBox;
    }
}

