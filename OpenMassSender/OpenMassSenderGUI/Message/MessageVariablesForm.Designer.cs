namespace OpenMassSenderGUI
{
    partial class MessageVariablesForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.lvVariables = new System.Windows.Forms.ListView();
            this.replace = new System.Windows.Forms.ColumnHeader();
            this.with = new System.Windows.Forms.ColumnHeader();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtWith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(276, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(200, 217);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // lvVariables
            // 
            this.lvVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.replace,
            this.with});
            this.lvVariables.Location = new System.Drawing.Point(12, 12);
            this.lvVariables.Name = "lvVariables";
            this.lvVariables.Size = new System.Drawing.Size(336, 199);
            this.lvVariables.TabIndex = 6;
            this.lvVariables.UseCompatibleStateImageBehavior = false;
            // 
            // replace
            // 
            this.replace.Text = "Replace";
            // 
            // with
            // 
            this.with.Text = "With";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(12, 266);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(335, 20);
            this.txtReplace.TabIndex = 7;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(8, 250);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(47, 13);
            this.lblReplace.TabIndex = 8;
            this.lblReplace.Text = "Replace";
            // 
            // txtWith
            // 
            this.txtWith.Location = new System.Drawing.Point(12, 314);
            this.txtWith.Name = "txtWith";
            this.txtWith.Size = new System.Drawing.Size(336, 20);
            this.txtWith.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "With";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // MessageVariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWith);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lvVariables);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.Add);
            this.Name = "MessageVariablesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MessageVariablesForm";
            this.Load += new System.EventHandler(this.MessageVariablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListView lvVariables;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader replace;
        private System.Windows.Forms.ColumnHeader with;
        private System.Windows.Forms.ErrorProvider errorProv;

    }
}