namespace OpenMassSenderGUI
{
    partial class ViewReceiversForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bntAddReceiver = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.bntSearchReceiver = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbReceiversGroup = new System.Windows.Forms.ToolStripComboBox();
            this.listViewReceivers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntAddReceiver,
            this.toolStripSeparator1,
            this.tbSearch,
            this.bntSearchReceiver,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cbReceiversGroup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bntAddReceiver
            // 
            this.bntAddReceiver.Image = global::OpenMassSenderGUI.Properties.Resources.add_button;
            this.bntAddReceiver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntAddReceiver.Name = "bntAddReceiver";
            this.bntAddReceiver.Size = new System.Drawing.Size(96, 22);
            this.bntAddReceiver.Text = "Add Receiver";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(300, 25);     
            // 
            // bntSearchReceiver
            // 
            this.bntSearchReceiver.Image = global::OpenMassSenderGUI.Properties.Resources.search_button;
            this.bntSearchReceiver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntSearchReceiver.Name = "bntSearchReceiver";
            this.bntSearchReceiver.Size = new System.Drawing.Size(62, 22);
            this.bntSearchReceiver.Text = "Search";
            this.bntSearchReceiver.Click += new System.EventHandler(this.bntSearchReceiver_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Select Group";
            // 
            // cbReceiversGroup
            // 
            this.cbReceiversGroup.Name = "cbReceiversGroup";
            this.cbReceiversGroup.Size = new System.Drawing.Size(121, 25);
            this.cbReceiversGroup.SelectedIndexChanged += new System.EventHandler(this.cbReceiversGroup_SelectedIndexChanged);
            // 
            // listViewReceivers
            // 
            this.listViewReceivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewReceivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewReceivers.Location = new System.Drawing.Point(0, 25);
            this.listViewReceivers.Name = "listViewReceivers";
            this.listViewReceivers.Size = new System.Drawing.Size(757, 558);
            this.listViewReceivers.TabIndex = 1;
            this.listViewReceivers.UseCompatibleStateImageBehavior = false;
            this.listViewReceivers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "email";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "phone number";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "metadata";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "group";
            this.columnHeader5.Width = 243;
            // 
            // ViewReceiversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 583);
            this.Controls.Add(this.listViewReceivers);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ViewReceiversForm";
            this.Text = "Managing Receivers";
            this.Load += new System.EventHandler(this.ViewReceiversForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bntAddReceiver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton bntSearchReceiver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbReceiversGroup;
        private System.Windows.Forms.ListView listViewReceivers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}