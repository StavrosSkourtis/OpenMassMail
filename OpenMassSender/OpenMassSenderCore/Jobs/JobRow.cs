using System;
using System.Collections.Generic;
using OpenMassSenderCore.Senders;
using OpenMassSenderCore.Jobs;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;


namespace OpenMassSenderCore
{
    public partial class OpenMassSenderDBDataSet
    {
        partial class JobRow
        {
            public static Dictionary<int, MassSender> massSenders = new Dictionary<int, MassSender>();


            public class JobStatus {public static string PENDING="PENDING",SHEDULED="SHEDULED",FINISHED="FINISHED"; };
            public string title;
            public MessageRow messageObject;
            public MassSender massSender;
            public JobScheduleRow scheduleObject;
            //<summary>returns true if the job is ready for execution,makes sense if the job has a shedule</summary>
            public bool isReadForExecution()
            {
                JobScheduleRow schedule = JobScheduleTableAdapter.getInstance().GetDataByID(this.schedule)[0];
                return schedule.ready(this);
            }

            //<summary>sets the status of the job between PENDING,SHEDULED,FINISHED</summary>
            //<param name="status">the status of the job</param>
            public void setStatus(JobStatus status)
            {
                //this.status = status;
            }

            public DateTime NextExecution
            {

                get
                {
                    JobScheduleRow schedule = (JobScheduleRow)JobScheduleTableAdapter.getInstance().GetDataByID(this.schedule).Rows[0];
                    return schedule.nextExecution;
                }
            }

            //<summary>returns the status of the job including all the SendStatusChanged messages that got isued</summary>
            public PendingJobStatus getStatus()
            {
                if (massSender == null) return null;
                return massSender.status;
            }

            //<summary>execute the job, aka send the message to the receivers</summary>
            //<returns>a PendingJobStatus object,the main idea is that this method will be called from the JobExecutionaire service
            //and the status of the executing job will be available to the desktop program via the JobExecutionaireInterface</returns>
            public PendingJobStatus execute()
            {
                JobScheduleRow schedule = JobScheduleTableAdapter.getInstance().GetDataByID(this.schedule)[0];
                if(massSenders.ContainsKey(this.ID))massSenders.Remove(ID);
                massSender=new MassSender();
                massSenders.Add(ID,massSender);

                List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receiversList = ReceiverTableAdapter.getInstance().searchReceivers(group, query);
    
                MessageRow message = (MessageRow)MessageTableAdapter.getInstance().GetDataById(this.message).Rows[0];
                SenderAccountRow sender = (SenderAccountRow)SenderAccountTableAdapter.getInstance().GetDataById(this.sender_account).Rows[0];

                Logger.log("creating mass sender for " + sender.ID + " message " + message.ID);
                this.status = JobStatus.PENDING;
                JobTableAdapter.getInstance().Update(this);
                massSender.send(sender,
                    message, receiversList, (SendStatusChanged status) =>
                {
                    try
                    {
                        if (massSender.sendsTried == massSender.totalSends)
                        {
                            if (schedule != null)
                            {
                                if (schedule.repeatable == RepeatableJob.NON_REPEATABLE)
                                {
                                    this.status = JobStatus.FINISHED;
                                }
                                else
                                {
                                    this.status = JobStatus.SHEDULED;
                                }
                                schedule.jobExecutionFinished();
                            }
                            Logger.log("job " + this.ID + " finished, next execution is " + schedule.nextExecution);
                            JobTableAdapter.getInstance().Update(this);
                            JobScheduleTableAdapter.getInstance().Update(schedule);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.error(ex.Message);
                    }
                });
      

                return massSender.status;
            }
        }
    }
}

