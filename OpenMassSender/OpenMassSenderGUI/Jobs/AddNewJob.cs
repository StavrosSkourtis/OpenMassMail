﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.Diagnostics;

namespace OpenMassSenderGUI
{
    public partial class AddNewJob : Form
    {
        bool editingJob = false;
        OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job;
        public AddNewJob(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job)
        {
            InitializeComponent();
            if (job == null) this.job = JobTableAdapter.getInstance().getNewRow();
            else
            {
                editingJob = true;
                job.messageObject = (OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow)MessageTableAdapter.getInstance().GetDataById(job.message).Rows[0];
                job.scheduleObject = (OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow)JobScheduleTableAdapter.getInstance().GetDataByID(job.schedule).Rows[0];

                if (job.query == null)
                {
                    recieverstextBox.Text = "group=" + job.group + ";";
                }
                else recieverstextBox.Text = "group=" + job.group + ";" + job.query;

                jobtextbox.Text = job.job_name;

                job.messageObject.linkedFile = "";
                this.job = job;

                executejob.Text = job.scheduleObject.nextExecution.ToString(); ;

                button4.Text = "Update job";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            delete.Hide();
            monthCalendar1.Show();

        }
        int temp = 0;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (temp == 0)
            {
                executejob.Text = monthCalendar1.SelectionStart.ToString();
                monthCalendar1.Visible = false;
                delete.Show();
            }
            if (temp == 1)
            {
                repeatjob.Items.Insert(0, monthCalendar1.SelectionStart.ToString());
                monthCalendar1.Visible = false;
                this.repeatjob.SelectedIndex = 0;

                delete.Show();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            String s = repeatjob.Text;
            if (s.Equals("Day") || s.Equals("Week") || s.Equals("Month") || s.Equals("Year"))
            {

            }
            else
            {
                repeatjob.Items.Remove(repeatjob.SelectedItem);
                this.repeatjob.SelectedIndex = 0;
            }


        }

        private void repeatjob_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = repeatjob.Text;
            if (s.Equals("Edit"))
            {
                delete.Hide();
                monthCalendar1.Show();
                temp = 1;

            }

        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            if (job != null && job.messageObject != null)
            {
                MessagePreviewForm messagePreview =new MessagePreviewForm(job.messageObject);
                

                messagePreview.Show();
                messagePreview.Focus();
            }
       }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageForm messageForm = new MessageForm(job.messageObject, this);
            messageForm.ShowDialog();
            
        }


        List<int> senderAccountsID = new List<int>();
        private void AddNewJob_Load(object sender, EventArgs e)
        {
            this.repeatjob.SelectedIndex = 0;
            int userId=Convert.ToInt32(UserTableAdapter.getInstance().userid);


            OpenMassSenderCore.OpenMassSenderDBDataSet.getInstance().EnforceConstraints = false;

            OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountDataTable dt=SenderAccountTableAdapter.getInstance().GetDataByUserID(userId);
            senderAccountsID.Clear();
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow row in dt.Rows)
            {
                string text="";
                if(row.type.Equals("sms")){
                    text=row.sms_url+" , "+"sms";
                }else{
                    text=row.email+" , "+"email";
                }
                cbSenderAccount.Items.Add(text);
                senderAccountsID.Add(row.ID);
            }
            this.cbSenderAccount.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewReceiversForm frm = new ViewReceiversForm((group,query)=>{
                job.group = group;
                job.query = query;
                recieverstextBox.Text = "group=" + group + ";" + query;
            }, job.group, job.query);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (job.group == null || job.group.Equals(""))
            {
                errorProvider1.SetError(button3, "You need to select the receivers");
                return;
            }

            if (jobtextbox.Text.Equals(""))
            {
                errorProvider1.SetError(jobtextbox, "You need to set a name");
                return;
            }
            if (executejob.Text.Equals(""))
            {
                errorProvider1.SetError(executejob, "You need to set a date");
                return;
            }
            if (job.messageObject.message.Equals(""))
            {
                errorProvider1.SetError(button1, "The message can't be empty");
                return;
            }
            
            
            if (jobtextbox.Text.Equals("") || executejob.Text.Equals(""))
            {
                MessageBox.Show("You must fill a job title,fill a subject of message and choose a date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (editingJob)
                {
                    job.title = job.job_name = jobtextbox.Text;
                    job.scheduleObject.nextExecution = Convert.ToDateTime(executejob.Text);
                    job.status = OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED;
                    job.scheduleObject.repeatable = repeatjob.Text;
                    
                    try
                    {
                        JobTableAdapter.getInstance().Update(job);
                        JobScheduleTableAdapter.getInstance().Update(job.scheduleObject);
                        MessageTableAdapter.getInstance().Update(job.messageObject);
                    }
                    catch (Exception ex) { }
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    while (true)
                    {
                        if (sw.ElapsedMilliseconds > 1000) break;
                    }
                    MainForm.Instance.refreshJobs();
                }
                else
                {
                    job.title = job.job_name = jobtextbox.Text;
                    job.scheduleObject.nextExecution = Convert.ToDateTime(executejob.Text);
                    job.status = OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED;
                    job.scheduleObject.repeatable = repeatjob.Text;
                    job.user = Convert.ToInt32(UserTableAdapter.getInstance().userid);


                    JobTableAdapter.getInstance().submitRow(job);

                    MainForm.Instance.refreshJobs();
                }
                this.Close();
            }
        }
        private void cbSenderAccount_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                job.sender_account = Convert.ToInt32(senderAccountsID[cbSenderAccount.SelectedIndex]);
                OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow s = (OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow)
                    SenderAccountTableAdapter.getInstance().GetDataById(job.sender_account).Rows[0];
                job.messageObject.type = s.type;
            }
            catch (Exception ex) { }
        }

        private void jobtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }

}
