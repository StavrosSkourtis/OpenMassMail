using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;
using OpenMassSenderCore.Users;

namespace OpenMassSenderCore.Managers
{
    //<summary>Singleton that contains all the receivers</summary>
    public class ReceiversManager
    {
        //<summary>A list with all the receivers</summary>
        private Dictionary<string, List<Receiver>> receivers = new Dictionary<string, List<Receiver>>();
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
        public List<Receiver> getAllReceiversOfGroup(string group)
        {
            List<Receiver> receiversList;
            receivers.TryGetValue(group,out receiversList);
            return receiversList;
        }

        //<sumarry>Searches all the receivers that match specific critirias</summary>
        //<param name="query">the critirias of the search, for example "location=Thessaloniki;age>18" returns
        //the receivers location in thessaloniki and are of age 19 or higher
        //<returns>a subset of all the receivers</returns>
        public List<Receiver> searchReceivers(string group,string query)
        {
            List<Receiver> receiversInGroup;
            List<Receiver> receiversMaching=new List<Receiver>();
            this.receivers.TryGetValue(group,out receiversInGroup);
            if (query.Equals("")){
                
                return receiversInGroup;
            }
            
            string[] queries = query.Split(';');
            foreach (Receiver receiver in receiversInGroup)
            {
                Boolean containsAll = true;
                foreach (string q in queries)
                {
                    if (receiver.metadata.Contains(q) == false) containsAll = false;
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
