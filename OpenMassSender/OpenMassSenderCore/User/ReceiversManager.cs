using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;

namespace OpenMassSenderCore.User
{
    class ReceiversManager
    {
        private List<Receiver> receivers = new List<Receiver>();
        //the logic for loading all the receivers that the user has added(from a db local/online)
        public void load(User user)
        {

        }
        //the logic for adding a new receiver
        public void add(Receiver receiver)
        {

        }
        public List<Receiver> getAllReceivers()
        {
            return receivers;
        }
        public List<Receiver> searchReceivers(string query)
        {
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
