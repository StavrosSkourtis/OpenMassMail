using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Receivers
{
    public class ReceiversList
    {
        public List<Receiver> receivers = new List<Receiver>();

        public List<Receiver> search(string query)
        {
            List<Receiver> receivers = new List<Receiver>();
            string[] queries=query.Split(';');
            foreach (Receiver receiver in this.receivers)
            {
                Boolean containsAll = true;
                foreach (string q in queries)
                {
                    if (receiver.metadata.Contains(q) == false)containsAll = false;
                }
                if (containsAll) receivers.Add(receiver);
            }
            return receivers;
        }
    }
}
