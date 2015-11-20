using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;

namespace OpenMassSenderCore.Messages
{
    public class Wildcards
    {
        public static string RECEIVER_FIRST_NAME = "$receiver_fname";
        public static string RECEIVER_LAST_NAME = "$receiver_lname";

    }


    public enum MessageStatus { ERROR, SUCCEED };
    public abstract class Message
    {
        //<summary>The status of the message</summary>
        public MessageStatus status;
        //<summary>A message can contain variables that are replaced upon send,for example $receiverName 
        //will be replaced with the receiver's name</summary>
        public Dictionary<string, string> replacableVariables = new Dictionary<string, string>();
        //<summary>The message the message(no shit sherlock)</summary>
        private string message;
        public void setMessage(string message)
        {
            this.message = message;
            if (message.Contains(Wildcards.RECEIVER_FIRST_NAME)) 
                replacableVariables.Add(Wildcards.RECEIVER_FIRST_NAME, null);
            if (message.Contains(Wildcards.RECEIVER_LAST_NAME))
                replacableVariables.Add(Wildcards.RECEIVER_LAST_NAME, null);
        }
        public string replaceWildCards(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
        {
            string ret = message;
            if(replacableVariables.ContainsKey(Wildcards.RECEIVER_FIRST_NAME))
                replacableVariables.Add(Wildcards.RECEIVER_FIRST_NAME, receiver.first_name);
            if (replacableVariables.ContainsKey(Wildcards.RECEIVER_LAST_NAME))
                replacableVariables.Add(Wildcards.RECEIVER_FIRST_NAME, receiver.last_name );

            foreach (KeyValuePair<string, string> entry in replacableVariables)
            {
                ret = ret.Replace(entry.Key, entry.Value);
            }
            return ret;
        }
    }
    class MailMessage : Message 
    { 
        public string subject;
    }
    class SMSMessage : Message
    {

    }
}
