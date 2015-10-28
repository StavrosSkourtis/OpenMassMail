using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Messages;

namespace OpenMassSenderCore.Senders
{
    class SMSSender:Sender
    {
        public override MessageStatus send(Message message, Receivers.Receiver receiver)
        {
            return MessageStatus.SUCCEED;
        }
    }
}
