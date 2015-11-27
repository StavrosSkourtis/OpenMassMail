using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore;

namespace OpenMassSenderGUI
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();
        }

        private void cbTags_Click(object sender, EventArgs e)
        {
            update(null);
        }
        private void update(object source)
        {
            if (cbTags.SelectedItem == null)
            {
                cbTags.SelectedIndex =1;
            }
            string tag = cbTags.SelectedItem.ToString();
            foreach(LogEntry log in Logger.logs){
                if (log.tag.Equals(tag) == false) continue;
                tbLog.Text += log.text + Environment.NewLine;
                Logger.logs.Remove(log);
            }
        }

        private void LoggerForm_Load(object sender, EventArgs e)
        {
            System.Threading.Timer timer = new System.Threading.Timer(update, null, 500, 500);

        }

        private void LoggerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
