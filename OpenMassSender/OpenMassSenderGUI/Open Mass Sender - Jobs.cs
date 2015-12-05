using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.IO;
using OpenMassSenderCore.Utils;


namespace OpenMassSenderGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Logger.logWindow = new LoggerForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  Testing testing = new Testing();
          // testing.Show();
            if (UserTableAdapter.getInstance().userid == null || UserTableAdapter.getInstance().userid.Equals(""))
            {
                showLoginForm();
            }
  
            //populate listview with data
            // Get the table from the data set
            DataTable dtable = OpenMassSenderDBDataSet.getInstance().Tables["Job"];

            // Clear the ListView control
            listViewJobs.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["status"].ToString());
                    lvi.SubItems.Add(drow["ID"].ToString());
                    //lvi.SubItems.Add(drow["price"].ToString());
                    //lvi.SubItems.Add(drow["pubdate"].ToString());

                    // Add the list items to the ListView
                    listViewJobs.Items.Add(lvi);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //----------------->thano edw<------------------------
            //kwdikas gia to anoigma tis add form
            AddNewJob newJobForm = new AddNewJob(null);
            newJobForm.Show();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        public void showLoginForm()
        {
            this.Hide();
            LoginForm loginForm = null;
            loginForm=new LoginForm((username,password,userid)=>{
                //write the user's id to a file so that the job execution service can know what user is logged in without the desktop
                //project running
                File.WriteAllText("omsloggeduser.dt", username + "|" + password + "|" + userid);
                loginForm.Close();
            });
            loginForm.TopMost = true;
            loginForm.ShowDialog();
        }

        private void manageSendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----------------->thano edw<------------------------
            //kwdikas gia to anoigma tis manage senders form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //apla gia na kanw testing to receiversWindow, den tha kanei load apo dw kanonika
            receiversWindow frm = new receiversWindow();
            frm.Show();
        }

        private void btnShowNotReady_Click(object sender, EventArgs e)
        {
            
        }
    }
}
