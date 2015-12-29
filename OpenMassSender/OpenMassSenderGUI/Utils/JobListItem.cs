using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using OpenMassSenderCore.Senders;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.Threading;
using OpenMassSenderCore;

namespace OpenMassSenderGUI.Utils
{
    
    class JobListItem : ListViewItem
    {
        private static string locker="";
        ListViewSubItem lblName, lblStatus;
        int id;
        public JobListItem(int id,String name,String status):base(id.ToString())
        {
            this.id = id;
            lblName = new ListViewSubItem();
            lblName.Text = name;

            lblStatus = new ListViewSubItem();
            lblStatus.Text = status;

            this.SubItems.Add(lblName);
            this.SubItems.Add(lblStatus);

            (new Thread(() =>
            {
                while (true)
                {
                    lock (locker)
                    {
                        update();
                        Thread.Sleep(800);
                    }
                }
            })).Start();
        }
        
        public void update()
        {
            try
            {
                OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job = (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow)JobTableAdapter.getInstance().GetDataById(id).Rows[0];

                if (job.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(job.ID.ToString());
                    lvi.SubItems.Add(job.job_name.ToString());
                    if (job.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED)
                    {
                        OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow schedule = (OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow)
                            JobScheduleTableAdapter.getInstance().GetDataByID(job.schedule).Rows[0];


                        lblStatus.Text = job.status + "(" + schedule.nextExecution + ")";

                    }
                    else if (job.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.PENDING)
                    {
                        MassSender massSender = null;
                        OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.massSenders.TryGetValue(id, out massSender);

                        if (massSender != null)
                        {
                            string perce = ("" + ((float)massSender.sendsTried / massSender.totalSends) * 100);
                            lblStatus.Text = job.status.ToString() + "(" + perce + "%)" + getPercentString((int)(((float)massSender.sendsTried / massSender.totalSends) * 100) / 2);
                        }
                        else
                        {
                            if (job.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.PENDING)
                            {
                                job.status = OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED;
                            }
                            lblStatus.Text = "Starting";
                            if (job.isReadForExecution()) job.execute();
                        }
                       
                    }
                }
            }
            catch (Exception ex) { Logger.log("here:"+ex.Message); }
        }

        public string getPercentString(int percent)
        {
            string p = "[";
            for (int c = 0; c < 50; c++)
            {
                if (c < percent) p += "-";
                else p += " ";
            }
            p += "]";
            return p;
        }
    }
}
