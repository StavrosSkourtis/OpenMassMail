﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace OpenMassSenderCore.Senders
{
    class SMSSender:Sender
    {
        OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow sender;
        public SMSSender(OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow sender)
        {
            this.sender = sender;
        }
        public override string send(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
        {
          
            try
            {
                string url = sender.sms_url;
                url = url.Replace("$to", receiver.phone_number.ToString());
                url = url.Replace("$message", message.replaceWildCards(receiver));

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            }
            catch (Exception ex) { return OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus.ERROR; }
            return OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus.SUCCEED;
        }
    }
}
