using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.Text.RegularExpressions;

namespace OpenMassSenderGUI
{
    public partial class AddReceiverForm : Form
    {
        public AddReceiverForm()
        {
            InitializeComponent();

            populateGroupComboBox();




        }


        private void populateGroupComboBox()
        {
            groupCB.Items.Clear();
            /*
             *  Loop through all the receivers and add the rows to the table
             */
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in ReceiverTableAdapter.getInstance().GetDataByDistinctGroups())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    groupCB.Items.Add(row.group);
                }
            }
            // IF there is at least on item in te combo box set the first one as the selected
            if (groupCB.Items.Count > 0)
                groupCB.SelectedIndex = 0;
        }

        private void createReceiverButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create the receiver?", "Creation Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {   

                string metadataString ="";

                foreach (DataGridViewRow row in metadataDGV.Rows)
                {
                    if (row.Index == metadataDGV.NewRowIndex)
                        break;
                    if (metadataString != "")
                        metadataString += ";";
                    
                    metadataString += row.Cells[0].Value + "=";
                    metadataString += row.Cells[1].Value;
                    
                }

                ReceiverTableAdapter.getInstance().Insert(emailTb.Text, phoneNumberTB.Text, metadataString, groupCB.Text, Convert.ToInt32(UserTableAdapter.getInstance().userid));
                this.Close();
            }
        }

        private void cancelReceiverButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the creation of the receiver?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void emailTb_Validating(object sender, CancelEventArgs e)
        {
            emailTb.BackColor = Color.White;
            //if email is empty then the user chose not to set value.
            if (emailTb.Text == "")
            {
                return;
            }

            try
            {
                //It will cause an exception if the email is not valid
                var addr = new System.Net.Mail.MailAddress(emailTb.Text);
            }
            catch
            {
                emailTb.BackColor = Color.FromArgb(255, 241, 115, 115);
                MessageBox.Show("The e-mail provided is not valid!", "E-mail not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void phoneNumberTB_Validating(object sender, CancelEventArgs e)
        {

            string pattern = "^(?:\\(?)(?<AreaCode>\\d{3})(?:[\\).]?)(?<Prefix>\\d{3})(?:[-\\.]?)(?<Suffix>\\d{4})(?!\\d)";

            Regex r = new Regex(pattern);

            if (phoneNumberTB.Text != "" && !r.IsMatch(phoneNumberTB.Text))
            {
                phoneNumberTB.BackColor = Color.FromArgb(255, 241, 115, 115);
                MessageBox.Show("The phone number provided is not valid! Example of correct phone numbers (xxx)xxx-xxxx , xxxxxxxxxx , xxx.xxx.xxxx .", "Phone number not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                phoneNumberTB.BackColor = Color.White;
            }

        }


        


    }
}
