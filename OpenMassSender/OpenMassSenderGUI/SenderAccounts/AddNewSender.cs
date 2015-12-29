using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenMassSenderGUI
{
    public partial class AddNewSender : Form
    {
       
        public AddNewSender()
        {
            

            InitializeComponent();
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
                // SenderAccountTableAdapter.getInstance().Insert(emailtextBox.Text, firsttextBox.Text, lasttextBox.Text, hosttextBox.Text, 21, "", Convert.ToInt32(UserTableAdapter.getInstance().userid), "");
                this.Close();
            }
        }

        private void emailtextBox_Leave(object sender, EventArgs e)
        {
            string address = emailtextBox.Text;
            hosttextBox.Text = address.Substring(address.IndexOf('@') + 1);
        }


       
       

        
    }
}
