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

        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleDataTable dataTable = new OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleDataTable();
        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow getNewRow()
        {
            return dataTable.NewJobScheduleRow();
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobScheduleRow row)
        {
            dataTable.Rows.Add(row);
            Update(dataTable);
        }

        private static JobScheduleTableAdapter instance;
        public static JobScheduleTableAdapter getInstance()
        {
            if (instance == null) instance = new JobScheduleTableAdapter();
            return instance;
        }

    }
}
