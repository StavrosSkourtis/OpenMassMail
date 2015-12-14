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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please fiil the fields to add a new user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Host";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(95, 72);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(163, 20);
            this.emailtextBox.TabIndex = 5;
            // 
            // firsttextBox
            // 
            this.firsttextBox.Location = new System.Drawing.Point(95, 124);
            this.firsttextBox.Name = "firsttextBox";
            this.firsttextBox.Size = new System.Drawing.Size(163, 20);
            this.firsttextBox.TabIndex = 6;
            // 
            // lasttextBox
            // 
            this.lasttextBox.Location = new System.Drawing.Point(95, 184);
            this.lasttextBox.Name = "lasttextBox";
            this.lasttextBox.Size = new System.Drawing.Size(163, 20);
            this.lasttextBox.TabIndex = 7;
            // 
            // hosttextBox
            // 
            this.hosttextBox.Location = new System.Drawing.Point(95, 237);
            this.hosttextBox.Name = "hosttextBox";
            this.hosttextBox.Size = new System.Drawing.Size(163, 20);
            this.hosttextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add New Sender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 336);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}