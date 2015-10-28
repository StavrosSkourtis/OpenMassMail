﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OpenMassSenderCore.User
{
    public enum LOGIN_STATUS{SUCCESS,FAILURE};
    class User
    {
        //<summary>asynchronus method for getting all the user's lists(receivers,jobs,senders),using lamda to notify when ready</summary>
        //<param name="username">the username</param>
        //<param name="password">the password</param>
        //<param name="onLogib">lamda for retung the status of the login once it finsihes
        public void login(string username,string password,Action<LOGIN_STATUS> onLogin)
        {
            (new Thread(() =>
            {
                //check if the userame and password maches

                //if login successfull then load the receivers and sender accounts
                ReceiversManager receiversManager = ReceiversManager.getInstance();
                receiversManager.load(this);

                SenderAccountsManager sendersManager = SenderAccountsManager.getInstance();
                sendersManager.load(this);

                JobsManager jobsManager = JobsManager.getInstance();
                jobsManager.load(this);

                onLogin(LOGIN_STATUS.SUCCESS);

                //else if login unsuccesfull
                //onLogin(LOGIN_STATUS.FAILURE);
            })).Start();
        }
        private static User instance;
        private User() { }
        public static User getInstance()
        {
            if (instance == null) instance = new User();
            return instance;
        }
    }
    
}
