using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Messages
{
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
