using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>Singleton that contains all the receivers</summary>

        partial class ReceiverTableAdapter
        {

            //<sumarry>Adds a new receiver</summary>
            //<param name="job">The receiver to add</param>
            public void add(string group, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
            {

            }
            //<sumarry>Returns a list with all the receivers</summary>
            public List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> getAllReceiversOfGroup(string group)
            {
                try
                {
                    OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable receivers = this.GetDataByGroup(Int32.Parse(UserTableAdapter.getInstance().userid), group);
                    List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receiversList = new List<OpenMassSenderDBDataSet.ReceiverRow>();
                    foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in receivers)
                    {
                        receiversList.Add(row);
                    }

                    return receiversList;
                }
                catch (Exception ex)
                {
                    Logger.log("error2", ex.Message);
                }
                return null;
            }

            //<sumarry>Searches all the receivers that match specific critirias</summary>
            //<param name="query">the critirias of the search, for example "location=Thessaloniki;age>18" returns
            //the receivers location in thessaloniki and are of age 19 or higher
            //<returns>a subset of all the receivers</returns>
            public List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> searchReceivers(string group, string query)
            {
   
                List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receiversInGroup = getAllReceiversOfGroup(group);
                List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receiversMaching = new List<OpenMassSenderDBDataSet.ReceiverRow>();
                if (query==null || query.Equals(""))
                {
                    foreach(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in receiversInGroup){
                        receiversMaching.Add(row);
                    }
                    return receiversMaching;
                }
                DataTable td = new DataTable();

                string[] queries = query.Split(';');
                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in receiversInGroup)
                {
                    Boolean containsAll = true;
                    foreach (string q in queries)
                    {
                        if (row["metadata"].ToString().Contains(q) == false) containsAll = false;
                    }
                    if (containsAll) receiversMaching.Add(row);
                }
                return receiversMaching;
            }

          
            public OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow getNewRow()
            {
                return OpenMassSenderDBDataSet.getInstance().Receiver.NewReceiverRow();
            }
            public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row)
            {
                OpenMassSenderDBDataSet.getInstance().Receiver.Rows.Add(row);
                Update(OpenMassSenderDBDataSet.getInstance().Receiver);
            }
             
            private static ReceiverTableAdapter instance;
            public static ReceiverTableAdapter getInstance()
            {
                if (instance == null) instance = new ReceiverTableAdapter();
                return instance;
            }
        }
    
}
