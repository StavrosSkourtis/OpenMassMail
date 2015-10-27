using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.SenderAccounts
{
    public class SenderAccount
    {
    }
    public class MailSenderAccount : SenderAccount
    {
        public string email;
        public int port;
        public string host;
    }
    public class SMSSenderAccount : SenderAccount
    {

    }
}
