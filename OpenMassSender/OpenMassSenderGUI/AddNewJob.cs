using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;

namespace OpenMassSenderGUI
{
    public partial class AddNewJob : Form
    {
        OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job;
        public AddNewJob(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job)
        {
            if (job == null) this.job = JobTableAdapter.getInstance().getNewRow();
            else this.job = job;
            InitializeComponent();
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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepathtextbox.Text = ofd.FileName;
                
            }
       }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageForm messageForm = new MessageForm(job.messageObject, this);
            messageForm.ShowDialog();
            
        }

        

        private void AddNewJob_Load(object sender, EventArgs e)
        {
            this.typecomboBox.SelectedIndex = 0;
            this.repeatjob.SelectedIndex = 0;

        }
        public string filepath
        {
            get { return filepathtextbox.Text; }
            set { filepathtextbox.Text = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            receiversWindow frm = new receiversWindow();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (jobtextbox.Text == "" || filepathtextbox.Text == "" || executejob.Text == "")
            {
                MessageBox.Show("You must fill a job title,fill a subject of message and choose a date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                this.Close();
            }
        }

        

        
    }

}
