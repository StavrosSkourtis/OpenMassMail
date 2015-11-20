using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Receivers
{
    public interface ContactInfo { }
    public class MailInfo : ContactInfo
    {
        public string mail;
        public MailInfo(string mail)
        {
            this.mail = mail;
        }
    }
    public class PhoneInfo : ContactInfo
    {
        public string phoneNumber;
        public PhoneInfo(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
