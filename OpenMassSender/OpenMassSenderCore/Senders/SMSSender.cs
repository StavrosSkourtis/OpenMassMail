using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Messages;
using OpenMassSenderCore.SenderAccounts;
using System.Net;
using System.IO;

namespace OpenMassSenderCore.Senders
{
    class SMSSender:Sender
    {
        SMSSenderAccount sender;
        public SMSSender(SMSSenderAccount sender)
        {
            this.sender = sender;
        }
        public override MessageStatus send(Message message, Receivers.Receiver receiver)
        {
            string url = sender.url;
            url = url.Replace("$to", receiver.getPhoneNumber().ToString());
            url = url.Replace("$message", message.replaceWildCards(receiver));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse  response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return MessageStatus.SUCCEED;
        }
    }
}
