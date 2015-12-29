using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading;


namespace OpenMassSenderCore.Senders 
{
    class MailSender : Sender
    {
        SmtpClient smtpClient;
        OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow sender;
        public MailSender(OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow sender)
        {
            this.sender = sender;
            smtpClient = new SmtpClient();
            smtpClient.Port = sender.port;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(sender.email, sender.password);
            smtpClient.Host = (string)sender.host;
        }
        public override string send(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message,OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(sender.email, receiver.email);
                mail.Subject = message.subject;
                mail.Body = message.replaceWildCards(receiver);
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Logger.error(ex.Message);
                return OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus.ERROR;
            }
            return OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus.SUCCEED;
        }
    }
}
