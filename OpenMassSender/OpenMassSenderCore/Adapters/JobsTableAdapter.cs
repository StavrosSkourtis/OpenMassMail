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
        //<summary>A list with all the jobs</summary>
        public string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }

        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobDataTable dataTable = new OpenMassSenderCore.OpenMassSenderDBDataSet.JobDataTable();
        public OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow getNewRow()
        {
            return dataTable.NewJobRow();
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobDataTable row)
        {
            dataTable.Rows.Add(row);
            Update(dataTable);
        }

        private static JobTableAdapter instance;
        public static JobTableAdapter getInstance()
        {
            if (instance == null) instance = new JobTableAdapter();
            return instance;
        }
    }
 
}
