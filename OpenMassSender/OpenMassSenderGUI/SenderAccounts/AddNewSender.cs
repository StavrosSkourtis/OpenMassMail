using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using OpenMassSenderGUI.Utils;
using System.Net.Mail;




namespace OpenMassSenderGUI
{
    public partial class AddNewSender : Form
    {
        int rowsOfSender = 0;
        public AddNewSender(int n)
        {


            InitializeComponent();
            rowsOfSender = n + 1;
            this.typecomboBox.SelectedIndex = 0;

        }

        private void emailTb_Validating(object sender, CancelEventArgs e)
        {
            emailtextBox.BackColor = Color.White;
            //if email is empty then the user chose not to set value.
            if (emailtextBox.Text == "")
            {
                return;
            }

            try
            {
                //It will cause an exception if the email is not valid
                var addr = new System.Net.Mail.MailAddress(emailtextBox.Text);
            }
            catch
            {
                emailtextBox.BackColor = Color.FromArgb(255, 241, 115, 115);
                MessageBox.Show("The e-mail provided is not valid!", "E-mail not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to cancel the creation of the sender?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to create the sender?", "Creation Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow row = SenderAccountTableAdapter.getInstance().getNewRow();
                row.ID = rowsOfSender;
                row.email = emailtextBox.Text;
                row.first_name = firsttextBox.Text;
                row.last_name = lasttextBox.Text;
                row.host = hosttextBox.Text;
                row.port = 0;
                row.sms_url = "";
                row.user = Convert.ToInt32(UserTableAdapter.getInstance().userid);
                row.type = typecomboBox.Text;
                row.password = "";
                SenderAccountTableAdapter.getInstance().submitRow(row);
                SenderAccountTableAdapter.getInstance().Update(row);
                this.Close();
            }
        }

        private void emailtextBox_Leave(object sender, EventArgs e)
        {

            string address = emailtextBox.Text;
            hosttextBox.Text = "smtp." + address.Substring(address.IndexOf('@') + 1);
        }

        private void typecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = typecomboBox.Text;
            if (s.Equals("sms"))
            {
                emailtextBox.Enabled = false;
                hosttextBox.Text = "";
                hosttextBox.Enabled = false;


            }
            else
            {
                emailtextBox.Enabled = true;
                hosttextBox.Enabled = true;
            }
        }

        

        






    }
}
