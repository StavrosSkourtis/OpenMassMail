using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.Common;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;

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
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job = JobTableAdapter.getInstance().getNewRow();

            job.query = "";
            job.group = "smaplist1";
            job.sender_account = 1;
            job.status = OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.PENDING;
            job.user = 1;


            job.messageObject.setMessage("hi $receiver_fname, This message send at $DATE(dd/MM/yyyy) is a notice");
            job.messageObject.subject = "A friendly notice";
            job.messageObject.job = job.ID;
            job.messageObject.replaceVariables = "customer=Customer";
            job.messageObject.user = job.user;
            job.messageObject.type = "email";
            job.messageObject.linkedFile = "";

            MessageForm msgForm = new MessageForm(job.messageObject, this);
            msgForm.Show();

            JobTableAdapter.getInstance().submitRow(job);
            MessageTableAdapter.getInstance().submitRow(job.messageObject);

            OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver = (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow)ReceiverTableAdapter.getInstance().GetDataById(1).Rows[0];

            Console.WriteLine("message:" + job.messageObject.replaceWildCards(receiver));

            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row in JobTableAdapter.getInstance().GetData())
            {
                Console.WriteLine("aa:" + row.ID+"  messag:"+row.message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job = JobTableAdapter.getInstance().GetDataById(1)[0];
            job.execute();
        }
    }
}
