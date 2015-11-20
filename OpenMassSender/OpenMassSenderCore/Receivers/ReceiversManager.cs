using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;
using OpenMassSenderCore.Users;
using System.Data;

namespace OpenMassSenderCore.Managers
{
    //<summary>Singleton that contains all the receivers</summary>
    public class ReceiversManager
    {
        private string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }
        
        //<sumarry>Adds a new receiver</summary>
        //<param name="job">The receiver to add</param>
        public void add(string group, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
        {

        }
        //<sumarry>Returns a list with all the receivers</summary>
        public OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable getAllReceiversOfGroup(string group)
        {
            return null;
        }

        //<sumarry>Returns a list with all the groups of receivers</summary>
        public OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable getAllReceiverGroups()
        {
            //TODO #stavros database stuff here
            return new OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable();
        }

        //<sumarry>Searches all the receivers that match specific critirias</summary>
        //<param name="query">the critirias of the search, for example "location=Thessaloniki;age>18" returns
        //the receivers location in thessaloniki and are of age 19 or higher
        //<returns>a subset of all the receivers</returns>
        public OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable searchReceivers(string group, string query)
        {
            OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable receiversInGroup = getAllReceiversOfGroup(group);
            OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable receiversMaching = new OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable();
            if (query.Equals(""))
            {
                return receiversInGroup;
            }
            DataTable td = new DataTable();

            string[] queries = query.Split(';');
            foreach (DataRow row in receiversInGroup.Rows)
            {
                Boolean containsAll = true;
                foreach (string q in queries)
                {
                    if (row["meta"].ToString().Contains(q) == false) containsAll = false;
                }
                if (containsAll) receiversMaching.Rows.Add(row);
            }
            return receiversMaching;
        }

        private static ReceiversManager instance;
        private ReceiversManager() { }
        public static ReceiversManager getInstance()
        {
            if (instance == null) instance = new ReceiversManager();
            return instance;
        }
    }
}
