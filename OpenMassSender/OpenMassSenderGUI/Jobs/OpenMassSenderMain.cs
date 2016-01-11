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
using OpenMassSenderGUI.Utils;


namespace OpenMassSenderGUI
{
    public partial class MainForm : Form
    {
        public static NotifyIcon notification;
        private MainForm()
        {
            InitializeComponent();
            Logger.logWindow = new LoggerForm();
            OpenMassSenderDBDataSet.getInstance();
            notification = this.notifyIcon1;
     
        }
        public void refreshJobs()
        {
            try
            {
                listViewJobs.Items.Clear();
                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row in JobTableAdapter.getInstance().GetData())
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        JobListItem item = new JobListItem(row.ID, row.job_name, row.status);
                        listViewJobs.Items.Add(item);
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.jobFinished=(job)=>{
                string text = "\"" + job.job_name + "\" finished";
                showBalloon("Job finished", text);
            };
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
                    JobListItem item = new JobListItem(row.ID, row.job_name, row.status);
                    listViewJobs.Items.Add(item);
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
                this.Show();
            });
            loginForm.TopMost = true;
            loginForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count > 0) {
                int idd;
                if( Int32.TryParse(listViewJobs.SelectedItems[0].Text, out idd) ){
                    MessageBox.Show(idd.ToString());
                    JobTableAdapter.getInstance().DeleteById(idd); //douleuei apla to kanw comment gt tha diagrapsei to mono mas job
                    refreshJobs();
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
            ManageS frm = new ManageS();
            frm.Show();
            
        }

        private void openLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerForm frm = new LoggerForm();
            frm.Show();
        }

        private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //MessageBox.Show( listViewJobs.SelectedItems[0].Text);
                DataTable dtable = OpenMassSenderDBDataSet.getInstance().Tables["Message"];
                listViewMessage.Items.Clear();
                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow row in MessageTableAdapter.getInstance().GetData())
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        if (listViewJobs.SelectedItems.Count > 0)
                        {
                            if (row.job.ToString().Equals(listViewJobs.SelectedItems[0].Text))
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
            catch (Exception ex) { }
        }
        private static MainForm instance;
        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to quit?",
                     "Quit",
                        MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showBalloon(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = this.Icon;
            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }

            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(2000);
        }

        private void listViewJobs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                String id = listViewJobs.SelectedItems[0].Text;
                OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job = (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow)JobTableAdapter.getInstance().GetDataById(Convert.ToInt32(id)).Rows[0];

                AddNewJob newJobForm = new AddNewJob(job);
                newJobForm.Show();
            }
            catch (Exception ex) { }

           
        }
    }
}
