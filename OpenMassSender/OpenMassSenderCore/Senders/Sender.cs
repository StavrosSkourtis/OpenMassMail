using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Messages;

namespace OpenMassSenderCore.Senders
{
   
    public abstract class Sender
    {
        public abstract MessageStatus send(Messages.Message message, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver);


    }
}
