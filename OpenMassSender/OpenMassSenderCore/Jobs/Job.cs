using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;
using OpenMassSenderCore.Messages;
using OpenMassSenderCore.SenderAccounts;
using OpenMassSenderCore.Senders;
using OpenMassSenderCore.Managers;

namespace OpenMassSenderCore.Jobs
{
    public enum JobStatus { PENDING, SHEDULED, FINISHED };
    public class Job
    {
        public string title;

        public ReceiversListDescriptor receiversDescriptor;
        public Message message;
        public SenderAccount sender;
        public JobShedule shedule;
        public JobStatus status;
        public MassSender massSender;

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

            massSender.send(this.sender,
                message,
                ReceiversManager.getInstance().searchReceivers(receiversDescriptor.group, receiversDescriptor.query)
                , (SendStatusChanged status) =>
            {
                Console.WriteLine("send to "+status.receiver.get("lastname")+" "+(status.status==MessageStatus.SUCCEED?"success":"failure"));
            });
            return massSender.status;
        }
    }
}
