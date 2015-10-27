using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace OpenMassSenderCore.Senders 
{
    class MailSender : Sender
    {
        SmtpClient smtpClient;
        SenderAccounts.MailSenderAccount sender;
        public MailSender(SenderAccounts.MailSenderAccount sender)
        {
            this.sender = sender;
            smtpClient = new SmtpClient();
            smtpClient.Port = sender.port;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = sender.host;
        }
        public override MessageStatus send(Message message, Receivers.Receiver receiver)
        {
            MailMessage mailMessage = (MailMessage)message;

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sender.email, receiver.getMail().mail);
            SmtpClient client = new SmtpClient();

            mail.Subject = mailMessage.subject;
            mail.Body = mailMessage.message;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                return MessageStatus.ERROR;
            }
            return MessageStatus.SUCCEED;
            
        }
    }
}
