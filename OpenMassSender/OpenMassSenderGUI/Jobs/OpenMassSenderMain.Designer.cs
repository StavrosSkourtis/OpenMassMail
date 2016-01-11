namespace OpenMassSenderGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewJobs = new System.Windows.Forms.ListView();
            this.ColumnNumber = new System.Windows.Forms.ColumnHeader();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senderAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMainWindow = new System.Windows.Forms.TabControl();
            this.tabPageStatus = new System.Windows.Forms.TabPage();
            this.listViewStatus = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.listViewMessage = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControlMainWindow.SuspendLayout();
            this.tabPageStatus.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 486);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewJobs);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlMainWindow);
            this.splitContainer1.Size = new System.Drawing.Size(565, 486);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewJobs
            // 
            this.listViewJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnNumber,
            this.ColumnName,
            this.columnStatus});
            this.listViewJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewJobs.FullRowSelect = true;
            this.listViewJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewJobs.Location = new System.Drawing.Point(0, 49);
            this.listViewJobs.MultiSelect = false;
            this.listViewJobs.Name = "listViewJobs";
            this.listViewJobs.Size = new System.Drawing.Size(565, 314);
            this.listViewJobs.TabIndex = 3;
            this.listViewJobs.UseCompatibleStateImageBehavior = false;
            this.listViewJobs.View = System.Windows.Forms.View.Details;
            this.listViewJobs.SelectedIndexChanged += new System.EventHandler(this.listViewJobs_SelectedIndexChanged);
            this.listViewJobs.DoubleClick += new System.EventHandler(this.listViewJobs_DoubleClick);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Text = "       #";
            this.ColumnNumber.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 200;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 317;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::OpenMassSenderGUI.Properties.Resources.add_button;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::OpenMassSenderGUI.Properties.Resources.delete_button;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemJobs,
            this.senderAccountsToolStripMenuItem,
            this.menuItemOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(42, 20);
            this.menuItemFile.Text = "User";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.connectToolStripMenuItem.Text = "Connect/Disconnect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // menuItemJobs
            // 
            this.menuItemJobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.menuItemJobs.Name = "menuItemJobs";
            this.menuItemJobs.Size = new System.Drawing.Size(68, 20);
            this.menuItemJobs.Text = "Receivers";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // senderAccountsToolStripMenuItem
            // 
            this.senderAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem1});
            this.senderAccountsToolStripMenuItem.Name = "senderAccountsToolStripMenuItem";
            this.senderAccountsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.senderAccountsToolStripMenuItem.Text = "Sender Accounts";
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem1.Text = "Manage";
            this.manageToolStripMenuItem1.Click += new System.EventHandler(this.manageToolStripMenuItem1_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLoggerToolStripMenuItem});
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.menuItemOptions.Text = "Options";
            // 
            // openLoggerToolStripMenuItem
            // 
            this.openLoggerToolStripMenuItem.Name = "openLoggerToolStripMenuItem";
            this.openLoggerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openLoggerToolStripMenuItem.Text = "Open Logger";
            this.openLoggerToolStripMenuItem.Click += new System.EventHandler(this.openLoggerToolStripMenuItem_Click);
            // 
            // tabControlMainWindow
            // 
            this.tabControlMainWindow.Controls.Add(this.tabPageStatus);
            this.tabControlMainWindow.Controls.Add(this.tabPageMessage);
            this.tabControlMainWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlMainWindow.Location = new System.Drawing.Point(0, 5);
            this.tabControlMainWindow.Name = "tabControlMainWindow";
            this.tabControlMainWindow.SelectedIndex = 0;
            this.tabControlMainWindow.Size = new System.Drawing.Size(565, 114);
            this.tabControlMainWindow.TabIndex = 0;
            // 
            // tabPageStatus
            // 
            this.tabPageStatus.Controls.Add(this.listViewStatus);
            this.tabPageStatus.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatus.Name = "tabPageStatus";
            this.tabPageStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatus.Size = new System.Drawing.Size(557, 88);
            this.tabPageStatus.TabIndex = 0;
            this.tabPageStatus.Text = "Status";
            this.tabPageStatus.UseVisualStyleBackColor = true;
            // 
            // listViewStatus
            // 
            this.listViewStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4});
            this.listViewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStatus.Location = new System.Drawing.Point(3, 3);
            this.listViewStatus.Name = "listViewStatus";
            this.listViewStatus.Size = new System.Drawing.Size(551, 82);
            this.listViewStatus.TabIndex = 5;
            this.listViewStatus.UseCompatibleStateImageBehavior = false;
            this.listViewStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Repeatable";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Next Execution";
            this.columnHeader4.Width = 317;
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.listViewMessage);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessage.Size = new System.Drawing.Size(557, 88);
            this.tabPageMessage.TabIndex = 1;
            this.tabPageMessage.Text = "Message";
            this.tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // listViewMessage
            // 
            this.listViewMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listViewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMessage.Location = new System.Drawing.Point(3, 3);
            this.listViewMessage.Name = "listViewMessage";
            this.listViewMessage.Size = new System.Drawing.Size(551, 82);
            this.listViewMessage.TabIndex = 4;
            this.listViewMessage.UseCompatibleStateImageBehavior = false;
            this.listViewMessage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Message";
            this.columnHeader3.Width = 317;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 486);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Jobs - Open Mass Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMainWindow.ResumeLayout(false);
            this.tabPageStatus.ResumeLayout(false);
            this.tabPageMessage.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlMainWindow;
        private System.Windows.Forms.TabPage tabPageStatus;
        private System.Windows.Forms.TabPage tabPageMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemJobs;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ListView listViewJobs;
        private System.Windows.Forms.ColumnHeader ColumnNumber;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLoggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senderAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ListView listViewMessage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewStatus;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
    }
}

