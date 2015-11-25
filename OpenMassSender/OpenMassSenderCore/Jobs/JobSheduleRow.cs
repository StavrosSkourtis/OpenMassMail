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
            public RepeatableJob repeatableShedule = RepeatableJob.NON_REPEATABLE;
            //<summary>returns true if the datetime has been reached and an execution is pending</summary>
            public bool ready()
            {
                JobRow job = (JobRow)JobTableAdapter.getInstance().GetDataById(this.job).Rows[0];
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
            public void jobExecutionStarted()
            {
                lastExecution = nextExecution;
                if (repeatableShedule == RepeatableJob.NON_REPEATABLE) nextExecution = DateTime.MaxValue;
                else if (repeatableShedule == RepeatableJob.DAILY) nextExecution = lastExecution.AddDays(1);
                else if (repeatableShedule == RepeatableJob.MONTHLY) nextExecution = lastExecution.AddMonths(1);
                else if (repeatableShedule == RepeatableJob.WEAKLY) nextExecution = lastExecution.AddDays(7);
                else if (repeatableShedule == RepeatableJob.YEARLY) nextExecution = lastExecution.AddYears(1);
            }

        }
    }
    public enum RepeatableJob { DAILY, WEAKLY, MONTHLY, YEARLY, NON_REPEATABLE };
}
