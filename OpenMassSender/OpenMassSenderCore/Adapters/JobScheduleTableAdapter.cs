using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class JobScheduleTableAdapter
    {
        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow getNewRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow schedule=OpenMassSenderDBDataSet.getInstance().JobSchedule.NewJobScheduleRow();
            job.schedule =schedule.ID;
            schedule.repeatable = RepeatableJob.NON_REPEATABLE;
            return schedule;
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow row)
        {
            OpenMassSenderDBDataSet.getInstance().JobSchedule.Rows.Add(row);
            Update(OpenMassSenderDBDataSet.getInstance().JobSchedule);
        }

        private static JobScheduleTableAdapter instance;
        public static JobScheduleTableAdapter getInstance()
        {
            if (instance == null) instance = new JobScheduleTableAdapter();
            return instance;
        }

    }
}
