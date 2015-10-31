using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Senders;
using OpenMassSenderCore.Receivers;

namespace OpenMassSenderCore.Jobs
{
    public class PendingJobStatus
    {
        public List<SendStatusChanged> sent = new List<SendStatusChanged>();
        public List<Receiver> pending = new List<Receiver>();
        public List<Receiver> all = new List<Receiver>();
        public double getPercent()
        {
            return ((double)sent.Count) / all.Count;
        }
    }
}
