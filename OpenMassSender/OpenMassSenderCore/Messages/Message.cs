using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Messages
{
    public enum MessageStatus { ERROR, SUCCEED };
    public abstract class Message
    {
        //<summary>The status of the message</summary>
        public MessageStatus status;
        //<summary>A message can contain variables that are replaced upon send,for example $receiverName 
        //will be replaced with the receiver's name</summary>
        public List<MessageVariable> replacableVariables = new List<MessageVariable>();
        //<summary>The message the message(no shit sherlock)</summary>
        public string message;
    }
    class MailMessage : Message 
    { 
        public string subject;
    }
    class SMSMessage : Message
    {

    }
}
