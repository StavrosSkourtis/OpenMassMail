using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Jobs;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    public partial class JobTableAdapter
    {
        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow getNewRow()
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job = OpenMassSenderDBDataSet.getInstance().Job.NewJobRow();
            OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message = MessageTableAdapter.getInstance().getNewRow(job);
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow shedule = JobScheduleTableAdapter.getInstance().getNewRow(job);

            return job;
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow row)
        {
            MessageTableAdapter.getInstance().submitRow(row.messageObject);
            JobScheduleTableAdapter.getInstance().submitRow(row.scheduleObject);

            OpenMassSenderDBDataSet.getInstance().Job.Rows.Add(row);
            Update(OpenMassSenderDBDataSet.getInstance().Job);

        }

        private static JobTableAdapter instance;
        public static JobTableAdapter getInstance()
        {
            if (instance == null) instance = new JobTableAdapter();
            return instance;
        }
    }
}
