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
                repeatjob.Items.Add(monthCalendar1.SelectionStart.ToString());
                monthCalendar1.Visible = false;
                delete.Show();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (repeatjob.SelectedIndex > 4)
            {
                repeatjob.Items.Remove(repeatjob.SelectedItem);
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
        private void checkform(){
            if (jobtextbox.Text == "" || typecomboBox.SelectedItem!=null  || filepathtextbox.Text == "" || recieverstextBox.Text == "" || executejob.Text == "") 
            {
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(job.messageObject);
            messageForm.ShowDialog();
        }

        private void executejob_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewJob_Load(object sender, EventArgs e)
        {

        }
    }

}
