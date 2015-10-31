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
        //<summary>the sms service http url, the $to and $content variables are replaced upon sending
        //for example http://smssender.com/send.php?id=1212132&to=$to&message=$content
        public string url;
    }
}
