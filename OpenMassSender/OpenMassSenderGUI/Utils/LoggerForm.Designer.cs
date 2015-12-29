namespace OpenMassSenderGUI
{
    partial class LoggerForm
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
            this.cbTags = new System.Windows.Forms.ToolStripComboBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.tag = new System.Windows.Forms.ColumnHeader();
            this.message = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbTags});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbTags
            // 
            this.cbTags.AutoCompleteCustomSource.AddRange(new string[] {
            "Errors",
            "Log",
            "Debug"});
            this.cbTags.Items.AddRange(new object[] {
            "Errors",
            "Log",
            "Debug"});
            this.cbTags.Name = "cbTags";
            this.cbTags.Size = new System.Drawing.Size(121, 25);
            this.cbTags.SelectedIndexChanged += new System.EventHandler(this.cbTags_SelectedIndexChanged);
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.tag,
            this.message});
            this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogs.Location = new System.Drawing.Point(0, 25);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(502, 488);
            this.lvLogs.TabIndex = 1;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Text = "Time";
            // 
            // tag
            // 
            this.tag.Text = "Tag";
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 300;
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 513);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoggerForm";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.LoggerForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggerForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbTags;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader tag;
        private System.Windows.Forms.ColumnHeader message;
    }
}