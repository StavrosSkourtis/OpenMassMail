using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class JobScheduleTableAdapter
    {
        private string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            
            return true;
        }
        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow getNewRow()
        {
            return OpenMassSenderDBDataSet.getInstance().JobSchedule.NewJobScheduleRow();
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
