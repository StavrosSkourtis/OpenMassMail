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
            public class JobStatus {public static string PENDING="PENDING",SHEDULED="SHEDULED",FINISHED="FINISHED"; };
            public string title;

            public SenderAccountRow sender;
            public MassSender massSender;
            //<summary>returns true if the job is ready for execution,makes sense if the job has a shedule</summary>
            public bool isReadForExecution()
            {
                
                JobScheduleRow shedule = (JobScheduleRow)JobScheduleTableAdapter.getInstance().GetDataByJob(ID).Rows[0];
                return shedule.ready();         
            }

            //<summary>sets the status of the job between PENDING,SHEDULED,FINISHED</summary>
            //<param name="status">the status of the job</param>
            public void setStatus(JobStatus status)
            {
                //this.status = status;
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
                
                massSender=new MassSender();
                OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable receivers = ReceiverTableAdapter.getInstance().searchReceivers(group, query);
                List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receiversList=new List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow>();
                foreach(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in receivers){
                    receiversList.Add(row);
                }
            
                MessageRow message = (MessageRow)MessageTableAdapter.getInstance().GetDataById(this.message).Rows[0];

                massSender.send(this.sender,
                    message, receiversList, (SendStatusChanged status) =>
                {
                    Logger.log("send to "+status.receiver.last_name+" "+(status.status==MessageStatus.SUCCEED?"success":"failure"));
                });
                return massSender.status;
            }
        }
    }
}

