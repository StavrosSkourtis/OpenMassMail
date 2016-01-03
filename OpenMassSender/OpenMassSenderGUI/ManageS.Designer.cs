namespace OpenMassSenderGUI
{
    partial class ManageS
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
            this.AddSendertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.senderdataGridView = new System.Windows.Forms.DataGridView();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSendertoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddSendertoolStripButton
            // 
            this.AddSendertoolStripButton.Image = global::OpenMassSenderGUI.Properties.Resources.add_button;
            this.AddSendertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSendertoolStripButton.Name = "AddSendertoolStripButton";
            this.AddSendertoolStripButton.Size = new System.Drawing.Size(115, 22);
            this.AddSendertoolStripButton.Text = "Add New Sender";
            this.AddSendertoolStripButton.Click += new System.EventHandler(this.AddSendertoolStripButton_Click);
            // 
            // senderdataGridView
            // 
            this.senderdataGridView.AllowUserToAddRows = false;
            this.senderdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.senderdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.senderdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.senderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.senderdataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.senderdataGridView.Location = new System.Drawing.Point(0, 28);
            this.senderdataGridView.Name = "senderdataGridView";
            this.senderdataGridView.Size = new System.Drawing.Size(690, 260);
            this.senderdataGridView.TabIndex = 1;
            this.senderdataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.senderdataGridView_UserDeletingRow);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(486, 315);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(81, 35);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(597, 315);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(81, 35);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "Save Changes";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // ManageS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 362);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.senderdataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManageS";
            this.Text = "ManageS";
            
           
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddSendertoolStripButton;
        private System.Windows.Forms.DataGridView senderdataGridView;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Savebutton;
    }
}