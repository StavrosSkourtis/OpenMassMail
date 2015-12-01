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
        
        public OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow getNewRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message = OpenMassSenderDBDataSet.getInstance().Message.NewMessageRow(); 
            message.subject = "";
            message.replaceVariables = "";
            message.user = 0;
            message.type ="";
            message.message = "";
            message.linkedFile ="";
            job.message = message.ID;
            job.messageObject = message;
            return message;
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow row)
        {
            OpenMassSenderDBDataSet.getInstance().Message.Rows.Add(row);
            Update(OpenMassSenderDBDataSet.getInstance().Message);
        }

        private static MessageTableAdapter instance;
        public static MessageTableAdapter getInstance()
        {
            if (instance == null) instance = new MessageTableAdapter();
            return instance;
        }
    }
}
