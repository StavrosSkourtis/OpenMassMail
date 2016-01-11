namespace OpenMassSenderGUI
{
    partial class AddNewJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewJob));
            this.label1 = new System.Windows.Forms.Label();
            this.jobtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.recieverstextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.executejob = new System.Windows.Forms.TextBox();
            this.repeatjob = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSenderAccount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Tittle";
            // 
            // jobtextbox
            // 
            this.jobtextbox.Location = new System.Drawing.Point(15, 29);
            this.jobtextbox.Name = "jobtextbox";
            this.jobtextbox.Size = new System.Drawing.Size(349, 20);
            this.jobtextbox.TabIndex = 1;
            this.jobtextbox.TextChanged += new System.EventHandler(this.jobtextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Content";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recievers";
            // 
            // recieverstextBox
            // 
            this.recieverstextBox.Enabled = false;
            this.recieverstextBox.Location = new System.Drawing.Point(15, 184);
            this.recieverstextBox.Name = "recieverstextBox";
            this.recieverstextBox.Size = new System.Drawing.Size(194, 20);
            this.recieverstextBox.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Execute On";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repeat";
            // 
            // executejob
            // 
            this.executejob.Location = new System.Drawing.Point(15, 250);
            this.executejob.Name = "executejob";
            this.executejob.Size = new System.Drawing.Size(115, 20);
            this.executejob.TabIndex = 12;
            // 
            // repeatjob
            // 
            this.repeatjob.FormattingEnabled = true;
            this.repeatjob.Items.AddRange(new object[] {
            "WEAKLY",
            "MONTHLY",
            "YEARLY",
            "NON_REPEATABLE"});
            this.repeatjob.Location = new System.Drawing.Point(165, 250);
            this.repeatjob.Name = "repeatjob";
            this.repeatjob.Size = new System.Drawing.Size(121, 21);
            this.repeatjob.TabIndex = 13;
            this.repeatjob.SelectedIndexChanged += new System.EventHandler(this.repeatjob_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(314, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 162);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(314, 154);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(339, 292);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(144, 23);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete Old  Dates";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add New Job";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(170, 133);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(116, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSenderAccount
            // 
            this.cbSenderAccount.FormattingEnabled = true;
            this.cbSenderAccount.Location = new System.Drawing.Point(15, 79);
            this.cbSenderAccount.Name = "cbSenderAccount";
            this.cbSenderAccount.Size = new System.Drawing.Size(512, 21);
            this.cbSenderAccount.TabIndex = 20;
            this.cbSenderAccount.SelectedValueChanged += new System.EventHandler(this.cbSenderAccount_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sender Account";
            // 
            // AddNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSenderAccount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.repeatjob);
            this.Controls.Add(this.executejob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.recieverstextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobtextbox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewJob";
            this.Text = "AddNewJob";
            this.Load += new System.EventHandler(this.AddNewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recieverstextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox executejob;
        private System.Windows.Forms.ComboBox repeatjob;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSenderAccount;
    }
}