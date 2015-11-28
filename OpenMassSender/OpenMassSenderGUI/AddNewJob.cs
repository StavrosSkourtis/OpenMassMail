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
    public partial class AddNewJob : Form
    {
        public AddNewJob()
        {
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
    }
}
