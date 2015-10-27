using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenMassSenderCore.SenderAccounts;

namespace OpenMassSenderCore.Senders
{
    public class MassSender
    {
        public static List<Thread> activeThreads = new List<Thread>();
        private static int MAX_THREADS = 200;
        public static void send(SenderAccount senderAccount,Message message, List<Receivers.Receiver> receivers, Action<SendStatusChanged> statusCallback)
        {
            int sendsPerThread = receivers.Count;
            for (int c = 0; c < MAX_THREADS; c++)
            {
                Sender sender=null;

                if (message is SMSMessage) sender = new SMSSender();
                else if (message is MailMessage) sender = new MailSender((SenderAccounts.MailSenderAccount)senderAccount);

                int count = sendsPerThread;
                if (sendsPerThread * c + count > receivers.Count) count = receivers.Count - sendsPerThread * c;
                List<Receivers.Receiver> subsetReceivers = receivers.GetRange(sendsPerThread * c, count);
                SenderThread senderThread = new SenderThread(sender, message, subsetReceivers, (status) => statusCallback(status));
                Thread workerThread = new Thread(senderThread.send);

                workerThread.Start();
            }
        }
    }
    public class SenderThread
    {
        Sender sender;
        Message message;
        List<Receivers.Receiver> receivers;
        Action<SendStatusChanged> statusCallback;
        public SenderThread(Sender sender, Message message, List<Receivers.Receiver> receivers,Action<SendStatusChanged> statusCallback)
        {
            this.message = message;
            this.receivers = receivers;
            this.sender = sender;
            this.statusCallback = statusCallback;
        }
        public void send()
        {
            foreach(Receivers.Receiver receiver in receivers){
                MessageStatus status=sender.send(message, receiver);
                statusCallback(new SendStatusChanged(receiver, status));
            }
        }
    }
    public class SendStatusChanged
    {
        Receivers.Receiver receiver;
        MessageStatus status;
        public SendStatusChanged(Receivers.Receiver receiver, MessageStatus status)
        {
            this.receiver = receiver;
            this.status = status;
        }
    }


}
