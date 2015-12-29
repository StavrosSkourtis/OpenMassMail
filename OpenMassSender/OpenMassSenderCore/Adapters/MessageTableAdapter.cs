using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class MessageTableAdapter
    {
        public OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow getNewRow(OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message = OpenMassSenderDBDataSet.getInstance().Message.NewMessageRow(); 
            message.subject = "";
            message.replaceVariables = "";
            message.user = Convert.ToInt32(UserTableAdapter.getInstance().userid);
            message.type ="";
            message.message = "";
            message.linkedFile ="";
            Console.WriteLine("aaww:" + this.SelectLastAddedId());
            message.ID = Convert.ToInt32(this.SelectLastAddedId()) + 1;
            
            
            job.message = message.ID;
            job.MessageRow = message;
            job.messageObject = message;
            return message;
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow row)
        {
            try
            {
                OpenMassSenderDBDataSet.getInstance().Message.Rows.Add(row);
                Update(OpenMassSenderDBDataSet.getInstance().Message);
            }
            catch (Exception ex) { }
        }

        private static MessageTableAdapter instance;
        public static MessageTableAdapter getInstance()
        {
            if (instance == null) instance = new MessageTableAdapter();
            return instance;
        }
    }
}
