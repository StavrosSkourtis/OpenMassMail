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
        //<summary>A list with all the receivers</summary>
        private Dictionary<string, DataTable> receivers = new Dictionary<string, DataTable>();
        //<sumarry>Loads the receivers list from the database</sumarry>
        //<param name="user">The loggedin user</param>
        public void load(string user)
        {

        }
        //<sumarry>Adds a new receiver</summary>
        //<param name="job">The receiver to add</param>
        public void add(string group,Receiver receiver)
        {

        }
        //<sumarry>Returns a list with all the receivers</summary>
        public DataTable getAllReceiversOfGroup(string group)
        {
            DataTable receiversList;
            receivers.TryGetValue(group,out receiversList);
            return receiversList;
        }

        //<sumarry>Returns a list with all the groups of receivers</summary>
        public DataTable getAllReceiverGroups(string group)
        {
            //TODO #stavros database stuff here
            return new DataTable();
        }

        //<sumarry>Searches all the receivers that match specific critirias</summary>
        //<param name="query">the critirias of the search, for example "location=Thessaloniki;age>18" returns
        //the receivers location in thessaloniki and are of age 19 or higher
        //<returns>a subset of all the receivers</returns>
        public DataTable searchReceivers(string group, string query)
        {
            DataTable receiversInGroup = getAllReceiversOfGroup(group);
            DataTable receiversMaching=new DataTable();
            if (query.Equals("")){
                return receiversInGroup;
            }
            DataTable td=new DataTable();

            string[] queries = query.Split(';');
            foreach (DataRow row in receiversInGroup.Rows)
            {
                Boolean containsAll = true;
                foreach (string q in queries)
                {
                    if (row("meta").Contains(q) == false) containsAll = false;
                }
                if (containsAll) receiversMaching.Add(receiver);
            }
            return receiversMaching;
        }

        private static ReceiversManager instance;
        private ReceiversManager() { }
        public static ReceiversManager getInstance()
        {
            if (instance == null)instance = new ReceiversManager();
            return instance;
        }
    }
}
