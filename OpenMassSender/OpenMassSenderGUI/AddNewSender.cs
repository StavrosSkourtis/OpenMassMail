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
        private ManageSender frm = null;
        public AddNewSender(Form mng)
        {
            frm = mng as ManageSender;

            InitializeComponent();
        }

        public string email
        {
            get { return emailtextBox.Text; }
            set { emailtextBox.Text = value; }
        }
        public string fname
        {
            get { return firsttextBox.Text; }
            set { firsttextBox.Text = value; }
        }
        public string lname
        {
            get { return lasttextBox.Text; }
            set { lasttextBox.Text = value; }
        }

        public string host
        {
            get { return hosttextBox.Text; }
            set { hosttextBox.Text = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (emailtextBox.Text == "" || firsttextBox.Text == "" || lasttextBox.Text == "" || hosttextBox.Text == "")
            {
                DialogResult result = MessageBox.Show("You must fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                { }

            }
            else
            {
                this.frm.email = email;
                this.frm.fname = fname;
                this.frm.lname = lname;
                this.frm.host = host;
                this.Close();
            }

        }

       

        
    }
}
