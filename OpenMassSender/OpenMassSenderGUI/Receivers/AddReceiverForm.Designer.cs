namespace OpenMassSenderGUI
{
    partial class AddReceiverForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCB = new System.Windows.Forms.ComboBox();
            this.cancelReceiverButton = new System.Windows.Forms.Button();
            this.createReceiverButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.metadataDGV = new System.Windows.Forms.DataGridView();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metadataDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter e-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter phone number:";
            // 
            // emailTb
            // 
            this.emailTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTb.Location = new System.Drawing.Point(142, 83);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(215, 20);
            this.emailTb.TabIndex = 2;
            this.emailTb.Validating += new System.ComponentModel.CancelEventHandler(this.emailTb_Validating);
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTB.Location = new System.Drawing.Point(142, 124);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(215, 20);
            this.phoneNumberTB.TabIndex = 3;
            this.phoneNumberTB.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberTB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select receiver group:";
            // 
            // groupCB
            // 
            this.groupCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCB.FormattingEnabled = true;
            this.groupCB.Location = new System.Drawing.Point(142, 165);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(215, 21);
            this.groupCB.TabIndex = 5;
            // 
            // cancelReceiverButton
            // 
            this.cancelReceiverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelReceiverButton.Location = new System.Drawing.Point(190, 502);
            this.cancelReceiverButton.Name = "cancelReceiverButton";
            this.cancelReceiverButton.Size = new System.Drawing.Size(71, 35);
            this.cancelReceiverButton.TabIndex = 6;
            this.cancelReceiverButton.Text = "Cancel";
            this.cancelReceiverButton.UseVisualStyleBackColor = true;
            this.cancelReceiverButton.Click += new System.EventHandler(this.cancelReceiverButton_Click);
            // 
            // createReceiverButton
            // 
            this.createReceiverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createReceiverButton.Location = new System.Drawing.Point(276, 502);
            this.createReceiverButton.Name = "createReceiverButton";
            this.createReceiverButton.Size = new System.Drawing.Size(81, 35);
            this.createReceiverButton.TabIndex = 7;
            this.createReceiverButton.Text = "Create";
            this.createReceiverButton.UseVisualStyleBackColor = true;
            this.createReceiverButton.Click += new System.EventHandler(this.createReceiverButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter receiver metadata (optional)";
            // 
            // metadataDGV
            // 
            this.metadataDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.metadataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metadataDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.dataValue});
            this.metadataDGV.Location = new System.Drawing.Point(15, 258);
            this.metadataDGV.Name = "metadataDGV";
            this.metadataDGV.Size = new System.Drawing.Size(342, 229);
            this.metadataDGV.TabIndex = 9;
            // 
            // dataName
            // 
            this.dataName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataName.HeaderText = "Name";
            this.dataName.Name = "dataName";
            // 
            // dataValue
            // 
            this.dataValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataValue.HeaderText = "Value";
            this.dataValue.Name = "dataValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Create new Receiver";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type the name of the new group, if the group doest not exists.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enter receiver information. A new id will be auto generated.";
            // 
            // AddReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metadataDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createReceiverButton);
            this.Controls.Add(this.cancelReceiverButton);
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(385, 588);
            this.Name = "AddReceiverForm";
            this.Text = "Creating new Receiver";
            ((System.ComponentModel.ISupportInitialize)(this.metadataDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupCB;
        private System.Windows.Forms.Button cancelReceiverButton;
        private System.Windows.Forms.Button createReceiverButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView metadataDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}