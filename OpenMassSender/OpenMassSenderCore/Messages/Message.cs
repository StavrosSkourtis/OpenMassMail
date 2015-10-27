using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Senders
{
    public enum MessageStatus { ERROR, SUCCEED };
    public abstract class Message
    {
        public string message;
    }
    class MailMessage : Message { public string subject; }
    class SMSMessage : Message { }
}
