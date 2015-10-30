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
        public DateTime nextExecution;
        public DateTime lastExecution;
        public JobShedule(Job job)
        {
            this.job = job;
        }
        //<summary>returns true if the datetime has been reached and an execution is pending</summary>
        public bool ready()
        {
            if (job.status == JobStatus.SHEDULED && nextExecution > DateTime.Now)
            {
                 return true;
            }
            return false;
        }
        //<summary>set the job to be executed immidiatly</summary>
        public void setImmediatly()
        {
            nextExecution = DateTime.Now;
        }
        //<summary>notify that the job execution has been started for the nextExecution date and set the nextExecution</summary>
        public void jobExecutionStarted()
        {
            lastExecution = nextExecution;
            if(repeatableShedule==RepeatableJob.NON_REPEATABLE)nextExecution=DateTime.MaxValue;
            else if(repeatableShedule==RepeatableJob.DAILY)nextExecution=lastExecution.AddDays(1);
            else if(repeatableShedule==RepeatableJob.MONTHLY)nextExecution=lastExecution.AddMonths(1);
            else if(repeatableShedule==RepeatableJob.WEAKLY)nextExecution=lastExecution.AddDays(7);
            else if(repeatableShedule==RepeatableJob.YEARLY)nextExecution=lastExecution.AddYears(1);
        }

    }

}
