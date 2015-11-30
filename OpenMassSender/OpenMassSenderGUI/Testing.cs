using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using OpenMassSenderCore;
using System.Data.Common;

namespace OpenMassSenderGUI
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job=JobTableAdapter.getInstance().getNewRow();
            OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message = MessageTableAdapter.getInstance().getNewRow();

            job.query = "";
            job.group = "smaplist1";
            job.sender_account = 1;
            job.status = OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.PENDING;
            job.user = 1;
            job.message =message.ID;

            message.subject = "A friendly notice";
            message.setMessage("hi $receiver_fname, This message send at $DATE(dd/MM/yyyy) is a notice");
            message.job = job.ID;
            message.replaceVariables = "customer=Customer";
            message.user = job.user;
            message.type = "email";
            message.linkedFile = "";

            MessageForm msgForm = new MessageForm(message);
            msgForm.Show();

            JobTableAdapter.getInstance().submitRow(job);
            MessageTableAdapter.getInstance().submitRow(message);

            OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver = (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow)ReceiverTableAdapter.getInstance().GetDataById(1).Rows[0];

            Console.WriteLine("message:" + message.replaceWildCards(receiver));

            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row in JobTableAdapter.getInstance().GetData())
            {
                Console.WriteLine("aa:" + row.ID+"  messag:"+row.message);
            }
            
        }
    }
}
