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
        //<summary>returns true if the job is ready for execution,makes sense if the job has a shedule</summary>
        public bool isReadForExecution()
        {
             return shedule.ready();         
        }
        //<summary>sets the status of the job between PENDING,SHEDULED,FINISHED</summary>
        //<param name="status">the status of the job</param>
        public void setStatus(JobStatus status)
        {
            this.status = status;
        }
    }
}
