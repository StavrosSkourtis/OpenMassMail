using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Jobs;
using System.IO;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;


namespace OMSExecutionerService
{
    //<summary>implementation of the JobExecutioner which will execute jobs when they will be ready, implements the interface
    //descirbed at CoreProject->Jobs->JobExecutionerInterface</summary>
    class JobExecutioner : JobExecutionerInterface
    {
        string userid;
        public JobExecutioner()
        {
            System.Threading.Timer timer = new System.Threading.Timer(executeIfReady, null, 3000, 3000);

            if (File.Exists("omsloggeduser.dt"))
            {
                setUser(File.ReadAllText("omsloggeduser.dt").Split('|')[2]);
            }
        }

        public void jobHasBeenAdded()
        {
            if (JobTableAdapter.getInstance().setUserID(userid)) executeIfReady(null);
        }
        //<summary>gets called by the desktop program as soon as the user gets authenticated,its part of the communication interface</summary>
        //<param name="user">the authenticated user</param>
        public void setUser(string user)
        {
            this.userid = user;
            ReceiverTableAdapter.getInstance().setUserID(user);

            if (user != null && JobTableAdapter.getInstance().setUserID(userid)) executeIfReady(null);
        }

        public void executeIfReady(object source)
        {
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job in JobTableAdapter.getInstance().GetData())
            {
                if (job.isReadForExecution())
                {
                    job.execute();
                }

            }
        }
    }
}
