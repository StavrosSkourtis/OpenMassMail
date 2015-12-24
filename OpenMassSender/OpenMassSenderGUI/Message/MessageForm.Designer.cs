namespace OpenMassSenderGUI
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbrnVariables = new System.Windows.Forms.ToolStripButton();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.lblLinkedFile = new System.Windows.Forms.Label();
            this.lblTextLengthWarning = new System.Windows.Forms.Label();
            this.btnFileLink = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.tbContent);
            this.panel1.Controls.Add(this.lblLinkedFile);
            this.panel1.Controls.Add(this.lblTextLengthWarning);
            this.panel1.Controls.Add(this.btnFileLink);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.labelContent);
            this.panel1.Controls.Add(this.labelSubject);
            this.panel1.Controls.Add(this.tbSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPreview,
            this.tsbrnVariables});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnPreview
            // 
            this.tsbtnPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPreview.Image")));
            this.tsbtnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPreview.Name = "tsbtnPreview";
            this.tsbtnPreview.Size = new System.Drawing.Size(52, 22);
            this.tsbtnPreview.Text = "Preview";
            this.tsbtnPreview.Click += new System.EventHandler(this.tsbtnPreview_Click);
            // 
            // tsbrnVariables
            // 
            this.tsbrnVariables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbrnVariables.Image = ((System.Drawing.Image)(resources.GetObject("tsbrnVariables.Image")));
            this.tsbrnVariables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbrnVariables.Name = "tsbrnVariables";
            this.tsbrnVariables.Size = new System.Drawing.Size(57, 22);
            this.tsbrnVariables.Text = "Variables";
            this.tsbrnVariables.Click += new System.EventHandler(this.tsbrnVariables_Click);
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.AutoWordSelection = true;
            this.tbContent.Location = new System.Drawing.Point(15, 109);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(538, 356);
            this.tbContent.TabIndex = 10;
            this.tbContent.Text = "";
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // lblLinkedFile
            // 
            this.lblLinkedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLinkedFile.AutoSize = true;
            this.lblLinkedFile.Location = new System.Drawing.Point(96, 480);
            this.lblLinkedFile.Name = "lblLinkedFile";
            this.lblLinkedFile.Size = new System.Drawing.Size(0, 13);
            this.lblLinkedFile.TabIndex = 8;
            // 
            // lblTextLengthWarning
            // 
            this.lblTextLengthWarning.AutoSize = true;
            this.lblTextLengthWarning.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTextLengthWarning.Location = new System.Drawing.Point(15, 452);
            this.lblTextLengthWarning.Name = "lblTextLengthWarning";
            this.lblTextLengthWarning.Size = new System.Drawing.Size(0, 13);
            this.lblTextLengthWarning.TabIndex = 7;
            // 
            // btnFileLink
            // 
            this.btnFileLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFileLink.Location = new System.Drawing.Point(15, 475);
            this.btnFileLink.Name = "btnFileLink";
            this.btnFileLink.Size = new System.Drawing.Size(75, 23);
            this.btnFileLink.TabIndex = 6;
            this.btnFileLink.Text = "Link a file";
            this.btnFileLink.UseVisualStyleBackColor = true;
            this.btnFileLink.Click += new System.EventHandler(this.btnFileLink_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(478, 475);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelContent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelContent.Location = new System.Drawing.Point(12, 90);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(53, 16);
            this.labelContent.TabIndex = 3;
            this.labelContent.Text = "Content";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelSubject.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelSubject.Location = new System.Drawing.Point(12, 32);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(53, 16);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject";
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubject.Location = new System.Drawing.Point(15, 51);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(535, 20);
            this.tbSubject.TabIndex = 0;
            this.tbSubject.TextChanged += new System.EventHandler(this.tbSubject_TextChanged);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(565, 510);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MessageForm";
            this.Text = "New Message";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button btnFileLink;
        private System.Windows.Forms.Label lblTextLengthWarning;
        private System.Windows.Forms.Label lblLinkedFile;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnPreview;
        private System.Windows.Forms.ToolStripButton tsbrnVariables;
    }
}