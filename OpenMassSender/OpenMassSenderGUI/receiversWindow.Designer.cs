﻿namespace OpenMassSenderGUI
{
    partial class receiversWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbSearchQuery = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchReceiver = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxReceiversGroup = new System.Windows.Forms.ToolStripComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(565, 486);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSearchQuery,
            this.btnSearchReceiver,
            this.ComboBoxReceiversGroup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbSearchQuery
            // 
            this.tbSearchQuery.Margin = new System.Windows.Forms.Padding(1, 6, 1, 0);
            this.tbSearchQuery.Name = "tbSearchQuery";
            this.tbSearchQuery.Size = new System.Drawing.Size(300, 23);
            this.tbSearchQuery.Click += new System.EventHandler(this.tbSearchQuery_Click);
            // 
            // btnSearchReceiver
            // 
            this.btnSearchReceiver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchReceiver.Image = global::OpenMassSenderGUI.Properties.Resources.search_button;
            this.btnSearchReceiver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchReceiver.Margin = new System.Windows.Forms.Padding(4, 6, 0, 2);
            this.btnSearchReceiver.Name = "btnSearchReceiver";
            this.btnSearchReceiver.Size = new System.Drawing.Size(23, 21);
            this.btnSearchReceiver.Text = "Search";
            this.btnSearchReceiver.Click += new System.EventHandler(this.btnSearchReceiver_Click);
            // 
            // ComboBoxReceiversGroup
            // 
            this.ComboBoxReceiversGroup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ComboBoxReceiversGroup.Margin = new System.Windows.Forms.Padding(20, 6, 1, 0);
            this.ComboBoxReceiversGroup.Name = "ComboBoxReceiversGroup";
            this.ComboBoxReceiversGroup.Size = new System.Drawing.Size(141, 23);
            this.ComboBoxReceiversGroup.TextChanged += new System.EventHandler(this.ComboBoxReceiversGroup_TextChanged);
            this.ComboBoxReceiversGroup.Click += new System.EventHandler(this.ComboBoxReceiversGroup_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(478, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // receiversWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 486);
            this.Controls.Add(this.panel1);
            this.Name = "receiversWindow";
            this.Text = "receiversWindow";
            this.Load += new System.EventHandler(this.receiversWindow_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbSearchQuery;
        private System.Windows.Forms.ToolStripButton btnSearchReceiver;
        private System.Windows.Forms.ToolStripComboBox ComboBoxReceiversGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
    }
}