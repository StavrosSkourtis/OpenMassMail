using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;

namespace OpenMassSenderCore.User
{
    //<summary>Singleton that contains all the receivers</summary>
    class ReceiversManager
    {
        //<summary>A list with all the receivers</summary>
        private List<Receiver> receivers = new List<Receiver>();
        //<sumarry>Loads the receivers list from the database</sumarry>
        //<param name="user">The loggedin user</param>
        public void load(User user)
        {

        }
        //<sumarry>Adds a new receiver</summary>
        //<param name="job">The receiver to add</param>
        public void add(Receiver receiver)
        {

        }
        //<sumarry>Returns a list with all the receivers</summary>
        public List<Receiver> getAllReceivers()
        {
            return receivers;
        }

        //<sumarry>Searches all the receivers that match specific critirias</summary>
        //<param name="query">the critirias of the search, for example "location=Thessaloniki;age>18" returns
        //the receivers location in thessaloniki and are of age 19 or higher
        //<returns>a subset of all the receivers</returns>
        public List<Receiver> searchReceivers(string query)
        {
            if (query.Equals("")) return this.receivers;
            List<Receiver> receivers = new List<Receiver>();
            string[] queries = query.Split(';');
            foreach (Receiver receiver in this.receivers)
            {
                Boolean containsAll = true;
                foreach (string q in queries)
                {
                    if (receiver.metadata.Contains(q) == false) containsAll = false;
                }
                if (containsAll) receivers.Add(receiver);
            }
            return receivers;
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
