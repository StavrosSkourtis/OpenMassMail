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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbReceiversGroup = new System.Windows.Forms.ToolStripComboBox();
            this.bntSearchReceiver = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvReceivers = new System.Windows.Forms.DataGridView();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntAddReceiver,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tbSearch,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cbReceiversGroup,
            this.bntSearchReceiver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel2.Text = "Enter Query";
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(300, 25);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            this.cbReceiversGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReceiversGroup.Name = "cbReceiversGroup";
            this.cbReceiversGroup.Size = new System.Drawing.Size(121, 25);
            this.cbReceiversGroup.SelectedIndexChanged += new System.EventHandler(this.cbReceiversGroup_SelectedIndexChanged);
            // 
            // bntSearchReceiver
            // 
            this.bntSearchReceiver.Image = global::OpenMassSenderGUI.Properties.Resources.search_button;
            this.bntSearchReceiver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntSearchReceiver.Name = "bntSearchReceiver";
            this.bntSearchReceiver.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.bntSearchReceiver.Size = new System.Drawing.Size(62, 22);
            this.bntSearchReceiver.Text = "Search";
            this.bntSearchReceiver.Click += new System.EventHandler(this.bntSearchReceiver_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvReceivers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetails);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(865, 553);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvReceivers
            // 
            this.dgvReceivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReceivers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReceivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceivers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReceivers.Location = new System.Drawing.Point(0, 0);
            this.dgvReceivers.MultiSelect = false;
            this.dgvReceivers.Name = "dgvReceivers";
            this.dgvReceivers.Size = new System.Drawing.Size(621, 553);
            this.dgvReceivers.TabIndex = 0;
            this.dgvReceivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceivers_CellClick);
            // 
            // dgvDetails
            // 
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.dataValue});
            this.dgvDetails.Location = new System.Drawing.Point(0, 26);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(240, 466);
            this.dgvDetails.TabIndex = 3;
            // 
            // dataName
            // 
            this.dataName.HeaderText = "dataName";
            this.dataName.Name = "dataName";
            // 
            // dataValue
            // 
            this.dataValue.HeaderText = "Value";
            this.dataValue.Name = "dataValue";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(147, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiver Details";
            // 
            // ViewReceiversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 578);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(776, 200);
            this.Name = "ViewReceiversForm";
            this.Text = "Managing Receivers";
            this.Load += new System.EventHandler(this.ViewReceiversForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReceivers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValue;
    }
}