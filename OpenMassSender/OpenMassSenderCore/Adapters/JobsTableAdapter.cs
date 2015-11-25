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
        private string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }

        private static JobTableAdapter instance;
        public static JobTableAdapter getInstance()
        {
            if (instance == null) instance = new JobTableAdapter();
            return instance;
        }
    }
 
}
