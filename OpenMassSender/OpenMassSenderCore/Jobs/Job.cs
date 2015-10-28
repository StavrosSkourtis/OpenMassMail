using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;
using OpenMassSenderCore.Messages;
using OpenMassSenderCore.SenderAccounts;

namespace OpenMassSenderCore.Jobs
{
    public enum JobStatus { PENDING, SHEDULED, FINISHED };
    public class Job
    {
        public string title;
        public List<Receiver> receivers = new List<Receiver>();
        public Message message;
        public SenderAccount sender;
        public JobShedule shedule;
        public JobStatus status;
        /*returns true if the specific task is ready to be executed */
        public bool isReadForExecution()
        {
            if (shedule == null) return true;
            else
            {
                return shedule.ready();
            }
        }
        public void setStatus(JobStatus status)
        {
            this.status = status;
        }
    }
}
