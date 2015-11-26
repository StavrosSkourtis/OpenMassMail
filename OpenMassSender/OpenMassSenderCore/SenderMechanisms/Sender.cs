using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OpenMassSenderCore.Senders
{
   
    public abstract class Sender
    {
        public abstract string send(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message, OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver);


    }
}
