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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.editLinkButton = new System.Windows.Forms.Button();
            this.removeLinkButton = new System.Windows.Forms.Button();
            this.addLinkButton = new System.Windows.Forms.Button();
            this.editIssueButton = new System.Windows.Forms.Button();
            this.removeIssueButton = new System.Windows.Forms.Button();
            this.addIssueButton = new System.Windows.Forms.Button();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.copiedLinkToClipboardLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
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
            this.groupsListBox.Size = new System.Drawing.Size(266, 554);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1257, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
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
            this.issueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueListBox.FormattingEnabled = true;
            this.issueListBox.HorizontalScrollbar = true;
            this.issueListBox.ItemHeight = 25;
            this.issueListBox.Location = new System.Drawing.Point(284, 67);
            this.issueListBox.Name = "issueListBox";
            this.issueListBox.Size = new System.Drawing.Size(414, 554);
            this.issueListBox.TabIndex = 2;
            this.issueListBox.SelectedIndexChanged += new System.EventHandler(this.issueListBox_SelectedIndexChanged);
            // 
            // issueTextBox
            // 
            this.issueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueTextBox.Location = new System.Drawing.Point(704, 179);
            this.issueTextBox.Multiline = true;
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issueTextBox.Size = new System.Drawing.Size(540, 442);
            this.issueTextBox.TabIndex = 4;
            this.issueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // issueNameLabel
            // 
            this.issueNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueNameLabel.AutoSize = true;
            this.issueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNameLabel.Location = new System.Drawing.Point(702, 36);
            this.issueNameLabel.Name = "issueNameLabel";
            this.issueNameLabel.Size = new System.Drawing.Size(110, 24);
            this.issueNameLabel.TabIndex = 13;
            this.issueNameLabel.Text = "Issue Name";
            // 
            // linksListBox
            // 
            this.linksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksListBox.FormattingEnabled = true;
            this.linksListBox.ItemHeight = 24;
            this.linksListBox.Location = new System.Drawing.Point(704, 97);
            this.linksListBox.Name = "linksListBox";
            this.linksListBox.Size = new System.Drawing.Size(540, 76);
            this.linksListBox.TabIndex = 15;
            this.linksListBox.SelectedIndexChanged += new System.EventHandler(this.linksListBox_SelectedIndexChanged_1);
            this.linksListBox.DoubleClick += new System.EventHandler(this.linksListBox_DoubleClick);
            // 
            // lockedCheckBox
            // 
            this.lockedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lockedCheckBox.AutoSize = true;
            this.lockedCheckBox.Location = new System.Drawing.Point(1183, 43);
            this.lockedCheckBox.Name = "lockedCheckBox";
            this.lockedCheckBox.Size = new System.Drawing.Size(62, 17);
            this.lockedCheckBox.TabIndex = 16;
            this.lockedCheckBox.Text = "Locked";
            this.lockedCheckBox.UseVisualStyleBackColor = true;
            this.lockedCheckBox.CheckedChanged += new System.EventHandler(this.lockedCheckBox_CheckedChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(383, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(247, 23);
            this.searchTextBox.TabIndex = 19;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToClipboardButton.BackgroundImage = global::Work_Links.Properties.Resources.copy;
            this.copyToClipboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyToClipboardButton.FlatAppearance.BorderSize = 0;
            this.copyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyToClipboardButton.Location = new System.Drawing.Point(1224, 70);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(20, 20);
            this.copyToClipboardButton.TabIndex = 21;
            this.toolTip.SetToolTip(this.copyToClipboardButton, "Copy Link");
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AccessibleDescription = "";
            this.clearSearchButton.AccessibleName = "";
            this.clearSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearSearchButton.BackgroundImage")));
            this.clearSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchButton.Location = new System.Drawing.Point(636, 34);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(27, 27);
            this.clearSearchButton.TabIndex = 20;
            this.toolTip.SetToolTip(this.clearSearchButton, "Clear Search");
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Visible = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = "";
            this.searchButton.AccessibleName = "";
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(669, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(27, 27);
            this.searchButton.TabIndex = 18;
            this.toolTip.SetToolTip(this.searchButton, "Search");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // editLinkButton
            // 
            this.editLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Pencil;
            this.editLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editLinkButton.FlatAppearance.BorderSize = 0;
            this.editLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLinkButton.Location = new System.Drawing.Point(756, 70);
            this.editLinkButton.Name = "editLinkButton";
            this.editLinkButton.Size = new System.Drawing.Size(20, 20);
            this.editLinkButton.TabIndex = 14;
            this.toolTip.SetToolTip(this.editLinkButton, "Edit Link");
            this.editLinkButton.UseVisualStyleBackColor = true;
            this.editLinkButton.Click += new System.EventHandler(this.editLinkButton_Click);
            // 
            // removeLinkButton
            // 
            this.removeLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Minus1;
            this.removeLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeLinkButton.FlatAppearance.BorderSize = 0;
            this.removeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeLinkButton.Location = new System.Drawing.Point(730, 70);
            this.removeLinkButton.Name = "removeLinkButton";
            this.removeLinkButton.Size = new System.Drawing.Size(20, 20);
            this.removeLinkButton.TabIndex = 12;
            this.toolTip.SetToolTip(this.removeLinkButton, "Remove Link");
            this.removeLinkButton.UseVisualStyleBackColor = true;
            this.removeLinkButton.Click += new System.EventHandler(this.removeLinkButton_Click);
            // 
            // addLinkButton
            // 
            this.addLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addLinkButton.BackgroundImage = global::Work_Links.Properties.Resources.Plus1;
            this.addLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addLinkButton.FlatAppearance.BorderSize = 0;
            this.addLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLinkButton.Location = new System.Drawing.Point(704, 70);
            this.addLinkButton.Name = "addLinkButton";
            this.addLinkButton.Size = new System.Drawing.Size(20, 20);
            this.addLinkButton.TabIndex = 11;
            this.toolTip.SetToolTip(this.addLinkButton, "Add Link");
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
            this.toolTip.SetToolTip(this.editIssueButton, "Edit Note");
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
            this.toolTip.SetToolTip(this.removeIssueButton, "Remove Note");
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
            this.toolTip.SetToolTip(this.addIssueButton, "Add Note");
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
            this.toolTip.SetToolTip(this.editGroupButton, "Edit Group");
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
            this.toolTip.SetToolTip(this.removeGroupButton, "Remove Group");
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
            this.toolTip.SetToolTip(this.addGroupButton, "Add Group");
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Work_Links.Properties.Resources.Pencil;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-69, -155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // copiedToClipboardLabel
            // 
            this.copiedLinkToClipboardLabel.AutoSize = true;
            this.copiedLinkToClipboardLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.copiedLinkToClipboardLabel.Location = new System.Drawing.Point(1120, 74);
            this.copiedLinkToClipboardLabel.Name = "copiedToClipboardLabel";
            this.copiedLinkToClipboardLabel.Size = new System.Drawing.Size(98, 13);
            this.copiedLinkToClipboardLabel.TabIndex = 22;
            this.copiedLinkToClipboardLabel.Text = "Copied to clipboard";
            this.copiedLinkToClipboardLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 636);
            this.Controls.Add(this.copiedLinkToClipboardLabel);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1273, 675);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Links";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.Label copiedLinkToClipboardLabel;
    }
}

