using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Messages
{
    //<summary>A message can contain variables that are replaced upon send,for example $receiverName 
    //will be replaced with the receiver's name</summary>
    public class MessageVariable
    {
        string variable, value;
        public MessageVariable(string variable, string value)
        {
            this.variable = variable;
            this.value = value;
        }
    }
}
