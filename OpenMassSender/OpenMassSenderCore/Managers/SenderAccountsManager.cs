using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.SenderAccounts;
using OpenMassSenderCore.Users;

namespace OpenMassSenderCore.Managers
{
    //<summary>A singleton containing all the sender accounts(sms provider login details or emails)</summary>
    class SenderAccountsManager
    {
        //<summary>a list with all the sender accounts</summary>
        private List<SenderAccount> senders = new List<SenderAccount>();
        //<summary>loads all the sender accounts from the db</summary>
        public void load(User user)
        {

        }
        //<summary>add a new sender account</summary>
        //<param name="senderAccount">the sender account to add</param>
        public void add(SenderAccount senderAccount)
        {

        }
        //<summary>returns all the senders</summary>
        public List<SenderAccount> getAllSenders()
        {
            return senders;
        }

        private static SenderAccountsManager instance;
        private SenderAccountsManager() { }
        public static SenderAccountsManager getInstance()
        {
            if (instance == null) instance = new SenderAccountsManager();
            return instance;
        }
    }
}
