using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class SenderAccountTableAdapter
    {
        public string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }
        private static SenderAccountTableAdapter instance;
        public static SenderAccountTableAdapter getInstance()
        {
            if (instance == null) instance = new SenderAccountTableAdapter();
            return instance;
        }
    }
}
