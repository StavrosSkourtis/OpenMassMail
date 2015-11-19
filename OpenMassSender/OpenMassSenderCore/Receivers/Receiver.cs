using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Receivers
{
    public class Receiver : Entity
    {        
        /*the following fields are now inside the fields<> dictionairy object,this makes it easier to 
         * manage in case we need to extend*/
        //public List<ContactInfo> contactInfo=new List<ContactInfo>();
        //public string firstname, lastname;
        //public string metadata;

        public MailInfo getMail()
        {
            foreach (KeyValuePair<string, Object> entry in fields)
            {
                if (!entry.Key.Equals("contactInfo")) continue;
                if (entry.Value is MailInfo) return (Receivers.MailInfo)entry.Value;
                // do something with entry.Value or entry.Key
            }          
            return null;
        }
        public PhoneInfo getPhoneNumber()
        {
            foreach (KeyValuePair<string, Object> entry in fields)
            {
                if (!entry.Key.Equals("contactInfo")) continue;
                if (entry.Value is PhoneInfo) return (Receivers.PhoneInfo)entry.Value;
                // do something with entry.Value or entry.Key
            }
            return null;
        }
    }
}
