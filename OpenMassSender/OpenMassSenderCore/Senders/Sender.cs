using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Senders
{
   
    public abstract class Sender
    {
        public abstract MessageStatus send(Message message, Receivers.Receiver receiver);


    }
}
