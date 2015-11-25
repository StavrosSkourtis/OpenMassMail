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
        private static JobScheduleTableAdapter instance;
        public static JobScheduleTableAdapter getInstance()
        {
            if (instance == null) instance = new JobScheduleTableAdapter();
            return instance;
        }
    }
}
