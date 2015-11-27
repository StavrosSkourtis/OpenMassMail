using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class MessageTableAdapter
    {
        public string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }
        

        public OpenMassSenderCore.OpenMassSenderDBDataSet.MessageDataTable dataTable = new OpenMassSenderCore.OpenMassSenderDBDataSet.MessageDataTable();
        public OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow getNewRow()
        {
            return dataTable.NewMessageRow();
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageDataTable row)
        {
            dataTable.Rows.Add(row);
            Update(dataTable);
        }

        private static MessageTableAdapter instance;
        public static MessageTableAdapter getInstance()
        {
            if (instance == null) instance = new MessageTableAdapter();
            return instance;
        }
    }
}
