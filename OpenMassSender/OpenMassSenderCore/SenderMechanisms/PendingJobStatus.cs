using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Senders;


namespace OpenMassSenderCore.Jobs
{
    public class PendingJobStatus
    {
        public List<SendStatusChanged> sent = new List<SendStatusChanged>();
        public List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> pending = new List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow>();
        public List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> all = new List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow>();
        public double getPercent()
        {
            return ((double)sent.Count) / all.Count;

        }
    }
}
