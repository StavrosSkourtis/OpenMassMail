using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.SenderAccounts;

namespace OpenMassSenderCore.User
{
    class SenderAccountsManager
    {
        private List<SenderAccount> senders = new List<SenderAccount>();
        //the logic for loading all the receivers that the user has added(from a db local/online)
        public void load(User user)
        {

        }
        //the logic for adding a new receiver
        public void add(SenderAccount senderAccount)
        {

        }
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
