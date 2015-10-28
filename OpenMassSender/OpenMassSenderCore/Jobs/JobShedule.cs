using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Jobs
{
    public enum RepeatableJob { DAILY, WEAKLY, MONTHLY, YEARLY,NON_REPEATABLE };
    public class JobShedule
    {
        public Job job;
        public RepeatableJob repeatableShedule = RepeatableJob.NON_REPEATABLE;
        public DateTime date;
        
        public JobShedule(Job job)
        {
            this.job = job;
        }
        //<summary>returns true if the datetime has been reached and an execution is pending</summary>
        public bool ready()
        {
            if (job.status == JobStatus.SHEDULED)
            {
                return true;
            }
            return false;
        }
    }

}
