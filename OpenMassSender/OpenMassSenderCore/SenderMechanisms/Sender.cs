using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OpenMassSenderCore.Senders
{
   
    public abstract class Sender
    {
        public abstract OpenMassSenderCore.OpenMassSenderDBDataSet.MessageStatus send(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver);


    }
}
