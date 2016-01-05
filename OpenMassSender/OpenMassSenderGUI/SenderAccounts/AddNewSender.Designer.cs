namespace OpenMassSenderGUI
{
    partial class AddNewSender
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.firsttextBox = new System.Windows.Forms.TextBox();
            this.lasttextBox = new System.Windows.Forms.TextBox();
            this.hosttextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Createbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create new Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter e-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter first name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter host name";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(141, 133);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(221, 20);
            this.emailtextBox.TabIndex = 5;
            this.emailtextBox.Leave += new System.EventHandler(this.emailtextBox_Leave);
            this.emailtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTb_Validating);
            // 
            // firsttextBox
            // 
            this.firsttextBox.Location = new System.Drawing.Point(141, 179);
            this.firsttextBox.Name = "firsttextBox";
            this.firsttextBox.Size = new System.Drawing.Size(221, 20);
            this.firsttextBox.TabIndex = 6;
            // 
            // lasttextBox
            // 
            this.lasttextBox.Location = new System.Drawing.Point(141, 229);
            this.lasttextBox.Name = "lasttextBox";
            this.lasttextBox.Size = new System.Drawing.Size(221, 20);
            this.lasttextBox.TabIndex = 7;
            // 
            // hosttextBox
            // 
            this.hosttextBox.Location = new System.Drawing.Point(141, 275);
            this.hosttextBox.Name = "hosttextBox";
            this.hosttextBox.Size = new System.Drawing.Size(221, 20);
            this.hosttextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter sender information. A new id will be auto generated.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(139, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type the name of the host  with (.com/,gr)";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(178, 346);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(71, 35);
            this.Cancelbutton.TabIndex = 12;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(281, 346);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(81, 35);
            this.Createbutton.TabIndex = 13;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "You enter a";
            // 
            // typecomboBox
            // 
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "email",
            "sms"});
            this.typecomboBox.Location = new System.Drawing.Point(141, 77);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(121, 21);
            this.typecomboBox.TabIndex = 15;
            this.typecomboBox.SelectedIndexChanged += new System.EventHandler(this.typecomboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "sender";
            // 
            // AddNewSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 393);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.typecomboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hosttextBox);
            this.Controls.Add(this.lasttextBox);
            this.Controls.Add(this.firsttextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSender";
            this.Text = "AddNewSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox firsttextBox;
        private System.Windows.Forms.TextBox lasttextBox;
        private System.Windows.Forms.TextBox hosttextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.Label label9;
    }
}