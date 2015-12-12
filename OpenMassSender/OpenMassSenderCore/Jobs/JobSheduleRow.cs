using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;

namespace OpenMassSenderCore
{
    public partial class OpenMassSenderDBDataSet
    {
        partial class JobScheduleRow
        {
            //<summary>returns true if the datetime has been reached and an execution is pending</summary>
            public bool ready(JobRow job)
            {
                if (job.status == OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow.JobStatus.SHEDULED && DateTime.Now > nextExecution)
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
            public void jobExecutionFinished()
            {
                lastExecution = nextExecution;
                
                if (repeatable == RepeatableJob.NON_REPEATABLE) nextExecution = DateTime.MaxValue;
                else if (repeatable == RepeatableJob.DAILY) nextExecution = lastExecution.AddDays(1);
                else if (repeatable == RepeatableJob.MONTHLY) nextExecution = lastExecution.AddMonths(1);
                else if (repeatable == RepeatableJob.WEAKLY) nextExecution = lastExecution.AddDays(7);
                else if (repeatable == RepeatableJob.YEARLY) nextExecution = lastExecution.AddYears(1);
            }

        }
    }
    public class RepeatableJob
    {
        public static string DAILY = "DAILY",
            WEAKLY = "WEAKLY", MONTHLY = "MONTHLY", YEARLY = "YEARLY", NON_REPEATABLE = "NON_REPEATABLE";
    };
}
