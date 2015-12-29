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
            int? id = this.SelectLastAddedId();
            if(id!=null)schedule.ID = Convert.ToInt32(id) + 1;
            job.schedule =schedule.ID;
            job.scheduleObject = schedule;
            schedule.repeatable = RepeatableJob.NON_REPEATABLE;
            return schedule;
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow row)
        {
            try
            {
                OpenMassSenderDBDataSet.getInstance().JobSchedule.Rows.Add(row);
                Update(OpenMassSenderDBDataSet.getInstance().JobSchedule);
            }
            catch (Exception ex) { }
        }

        private static JobScheduleTableAdapter instance;
        public static JobScheduleTableAdapter getInstance()
        {
            if (instance == null) instance = new JobScheduleTableAdapter();
            return instance;
        }

    }
}
