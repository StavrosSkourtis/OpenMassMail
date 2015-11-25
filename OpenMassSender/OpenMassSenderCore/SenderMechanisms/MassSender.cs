using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenMassSenderCore.Senders;
using OpenMassSenderCore.Jobs;

namespace OpenMassSenderCore.Senders
{
    public class MassSender
    {
        //<summary>holds the status of a pending(currently executing) job</summary>
        public PendingJobStatus status=new PendingJobStatus();

        //<summary>A list with all the active threads of this particular mass sender,a job has only one mass sender
        //this list can be used to stop all the threads in case we need to cancel the job</summary>
        public List<Thread> activeThreads = new List<Thread>();

        //<summary>The maximum amount of threads we are gonna use for this job</summary>
        private int max_threads = 200;

        //<summary>Call this to send a message to multiple receivers by using multiple threads</summary>
        //<param name="statusCallback">Lamda that gets called every time a message has been sended,
        //it returns the status of the transmition(FAILED,SUCCEDED) along with the receiver's inforation</param>
        public void send(OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow senderAccount,OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message, List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receivers, Action<SendStatusChanged> statusCallback)
        {
            status.all.AddRange(receivers);
            status.pending.AddRange(receivers);

            int threads = Math.Min(receivers.Count, max_threads);

            int sendsPerThread = receivers.Count / threads;
            if (receivers.Count < threads) sendsPerThread = 1;

            for (int c = 0; c < threads; c++)
            {
                Sender sender=null;

                if (message.type.Equals("sms")) sender = new SMSSender(senderAccount);
                else if (message.type.Equals("email")) sender = new MailSender(senderAccount);

                int count = sendsPerThread;
                if (sendsPerThread * c + count > receivers.Count) count = receivers.Count - sendsPerThread * c;
                List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> subsetReceivers = receivers.GetRange(sendsPerThread * c, count);

                SenderThread senderThread = new SenderThread(status, sender, message, subsetReceivers, (sentStatus) => statusCallback(sentStatus));
                Thread workerThread = new Thread(senderThread.send);

                workerThread.Start();
            }
        }
    }
    public class SenderThread
    {
        Sender sender;
        OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message;
        List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receivers;
        Action<SendStatusChanged> statusCallback;
        PendingJobStatus pendingJobStatus;
        public SenderThread(PendingJobStatus pendingJobStatus, Sender sender, OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message, List<OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow> receivers, Action<SendStatusChanged> statusCallback)
        {
            this.pendingJobStatus = pendingJobStatus;
            this.message = message;
            this.receivers = receivers;
            this.sender = sender;
            this.statusCallback = statusCallback;
        }

        //<summary>For each receiver that belongs to the current thread,send the message and return the status of the
        //by using the callback</summary>
        public void send()
        {
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver in receivers)
            {
                OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus status = sender.send(message, receiver);
                SendStatusChanged sentStatus = new SendStatusChanged(receiver, status);
                pendingJobStatus.pending.Remove(receiver);
                pendingJobStatus.sent.Add(sentStatus);
                statusCallback(sentStatus);
            }
        }
    }
    public class SendStatusChanged
    {
        public OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver;
        public OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus status;
        public SendStatusChanged(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver, OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus status)
        {
            this.receiver = receiver;
            this.status = status;
        }
    }


}
