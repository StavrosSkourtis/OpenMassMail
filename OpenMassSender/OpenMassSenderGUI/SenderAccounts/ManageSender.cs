using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace OpenMassSenderGUI
{
    public partial class ManageSender : Form
    {
        public string email;
        public string fname;
        public string lname;
        public string host;
        public int temp = 0;
        public ManageSender()
        {
            InitializeComponent();
        }

        private void ManageSender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'openMassSenderDBDataSet.SenderAccount' table. You can move, or remove it, as needed.
            this.senderAccountTableAdapter.Fill(this.openMassSenderDBDataSet.SenderAccount);

        }

        private void AddtoolStripButton_Click(object sender, EventArgs e)
        {
            AddNewSender newsender = new AddNewSender();
            newsender.Show();
            temp = 1;

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\THANOS\\Desktop\\OpenMassMail\\OpenMassSender\\OpenMassSenderCore\\OpenMassSenderDB.accdb");

        private void ManageSender_Activated(object sender, EventArgs e)
        {

            int n = senderdataGridView.Rows.Count;
            if (temp == 1)
            {


                con.Open();

                string query = "insert into SenderAccount values(@id,@email,@first_name,@last_name,@host,@port,@sms_url,@user,@type)";
                OleDbCommand exe = new OleDbCommand(query, con);
                exe.Parameters.AddWithValue("@id", n);
                exe.Parameters.AddWithValue("@email", email);
                exe.Parameters.AddWithValue("@first_name", fname);
                exe.Parameters.AddWithValue("@last_name", lname);
                exe.Parameters.AddWithValue("@host", host);
                exe.Parameters.AddWithValue("@port", 0);
                exe.Parameters.AddWithValue("@sms_url", "");
                exe.Parameters.AddWithValue("@user", 0);
                exe.Parameters.AddWithValue("@type", "");


                exe.ExecuteNonQuery();
                con.Close();

                this.senderAccountTableAdapter.Fill(this.openMassSenderDBDataSet.SenderAccount);
                temp = 0;
            }// telos if temp=1

        }

    }
}
