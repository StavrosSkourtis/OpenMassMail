using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
