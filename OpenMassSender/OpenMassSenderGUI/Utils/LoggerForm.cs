using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore;
using System.Threading;

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
            update();
        }
        private void update()
        {
            Console.WriteLine("CURENT L222OG:");
            if (cbTags.SelectedItem == null)
            {
                cbTags.SelectedIndex =1;
            }
            string tag = cbTags.SelectedItem.ToString().ToUpper();
            foreach(LogEntry log in Logger.logs){
                if (log.consumed || log.tag.Equals(tag) == false) continue;
                var listViewItem = new ListViewItem(new string[] { log.date.Hour + ":" + log.date.Minute + ":" + log.date.Second, log.tag, log.text });
                lvLogs.Items.Add(listViewItem);
                log.consumed = true;
            }
        }
        Thread logThread = null;
        private void LoggerForm_Load(object sender, EventArgs e)
        {
            (logThread=new Thread(() => {
                while (true)
                {
                    update();
                    Thread.Sleep(500);
                }
            })).Start();
        }

        private void LoggerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            if (logThread != null) logThread.Abort();
        }
    }
}
