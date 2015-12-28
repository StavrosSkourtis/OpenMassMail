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
using System.ServiceProcess;
using OMSExecutionerService;
using System.Threading;
using OpenMassSenderCore.Senders;


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
            //Get the table from the data set
            DataTable dtable = OpenMassSenderDBDataSet.getInstance().Tables["Job"];
            //Clear the ListView control
            listViewJobs.Items.Clear();
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row in JobTableAdapter.getInstance().GetData())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(row.ID.ToString());
                    lvi.SubItems.Add(row.job_name.ToString());
                    lvi.SubItems.Add(row.status.ToString());
                    //lvi.SubItems.Add(row["status"].ToString());
                    // Add the list items to the ListView
                    listViewJobs.Items.Add(lvi);
                }
            }

            //(new Thread(() =>
           //{
               /*
                while (true)
                {
                    //populate listview with data
                    // Get the table from the data set
                    DataTable dtable = OpenMassSenderDBDataSet.getInstance().Tables["Job"];

                    // Clear the ListView control
                    listViewJobs.Items.Clear();
                    // Display items in the ListView control
                    foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row in JobTableAdapter.getInstance().GetDataByUser(Int32.Parse(UserTableAdapter.getInstance().userid)))
                    {
                        // Only row that have not been deleted
                        if (row.RowState != DataRowState.Deleted)
                        {
                            // Define the list items
                            ListViewItem lvi = new ListViewItem(row.ID.ToString());
                            lvi.SubItems.Add(row.job_name.ToString());
                            if (row.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED)
                            {
                                lvi.SubItems.Add(row.status.ToString() + "(" + row.NextExecution + ")");
                            }
                            else if (row.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.PENDING)
                            {
                                MassSender massSender=null;
                                OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.massSenders.TryGetValue(row.ID, out massSender);
                                if (massSender != null)
                                {
                                    lvi.SubItems.Add(row.status.ToString() + "(" + ((float)massSender.sendsTried / massSender.totalSends) * 100 + "%)");
                                }
                                else
                                {
                                    lvi.SubItems.Add(row.status.ToString());
                                }
                            }



                            // Add the list items to the ListView
                            listViewJobs.Items.Add(lvi);
                        }
                    }
                    Thread.Sleep(1000);
               
                }
                */
          // })).Start();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count > 0) {
                int idd;
                if( Int32.TryParse(listViewJobs.SelectedItems[0].Text, out idd) ){
                    //MessageBox.Show(idd.ToString());
                    //JobTableAdapter.getInstance().DeleteById(idd); //douleuei apla to kanw comment gt tha diagrapsei to mono mas job
                }else {
                    MessageBox.Show("String could not be parsed.");
                }                
            }
        }

        private void btnShowNotReady_Click(object sender, EventArgs e)
        {
            
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReceiversForm frm = new ViewReceiversForm(null,null,null);
            frm.Show();
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageSender frm = new ManageSender();
            frm.Show();
            
        }

        private void openLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerForm frm = new LoggerForm();
            frm.Show();
        }

        private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show( listViewJobs.SelectedItems[0].Text);
            DataTable dtable = OpenMassSenderDBDataSet.getInstance().Tables["Message"];
            listViewMessage.Items.Clear();
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow row in MessageTableAdapter.getInstance().GetData())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    if(listViewJobs.SelectedItems.Count > 0) {
                        if (row.ID.ToString().Equals(listViewJobs.SelectedItems[0].Text))
                        {
                            ListViewItem lvi = new ListViewItem(row.subject.ToString());
                            lvi.SubItems.Add(row.message.ToString());
                            listViewMessage.Items.Add(lvi);
                        }
                    }
                }
            }

            DataTable dtable1 = OpenMassSenderDBDataSet.getInstance().Tables["JobSchedule"];
            listViewStatus.Items.Clear();
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow row in JobScheduleTableAdapter.getInstance().GetData())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    if (listViewJobs.SelectedItems.Count > 0)
                    {
                        if (row.ID.ToString().Equals(listViewJobs.SelectedItems[0].Text))
                        {
                            ListViewItem lvi = new ListViewItem(row.repeatable.ToString());
                            lvi.SubItems.Add(row.nextExecution.ToString());
                            listViewStatus.Items.Add(lvi);
                        }
                    }
                }
            }
        }
    }
}
