using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    partial class SenderAccountTableAdapter
    {
        public OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow getNewRow()
        {
            return OpenMassSenderDBDataSet.getInstance().SenderAccount.NewSenderAccountRow();
        }
        public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow row)
        {
            OpenMassSenderDBDataSet.getInstance().SenderAccount.Rows.Add(row);
            Update(OpenMassSenderDBDataSet.getInstance().SenderAccount);
        }

        private static SenderAccountTableAdapter instance;
        public static SenderAccountTableAdapter getInstance()
        {
            if (instance == null) instance = new SenderAccountTableAdapter();
            return instance;
        }
    }
}
