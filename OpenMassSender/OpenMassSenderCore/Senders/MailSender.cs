using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using OpenMassSenderCore.Messages;

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
            OpenMassSenderCore.Messages.MailMessage mailMessage = (OpenMassSenderCore.Messages.MailMessage)message;
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sender.email, receiver.getMail().mail);
            mail.Subject = mailMessage.subject;
            mail.Body = mailMessage.replaceWildCards(receiver);
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                return MessageStatus.ERROR;
            }
            return MessageStatus.SUCCEED;
        }
    }
}
