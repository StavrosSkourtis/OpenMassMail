using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Receivers
{
    public class Receiver
    {
        public List<ContactInfo> contactInfo=new List<ContactInfo>();
        public string firstname, lastname;
        public string metadata;
        public MailInfo getMail()
        {
            foreach (ContactInfo ci in contactInfo)
                if (ci is MailInfo) return (Receivers.MailInfo)ci;
            return null;
        }
        public PhoneInfo getPhoneNumber()
        {
            foreach (Receivers.ContactInfo ci in contactInfo)
                if (ci is PhoneInfo) return (Receivers.PhoneInfo)ci;
            return null;
        }
    }
}
