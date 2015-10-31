using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Jobs;
using OpenMassSenderCore.Managers;
using OpenMassSenderCore.Users;
using System.IO;


namespace OMSExecutionerService
{
    //<summary>implementation of the JobExecutioner which will execute jobs when they will be ready, implements the interface
    //descirbed at CoreProject->Jobs->JobExecutionerInterface</summary>
    class JobExecutioner : JobExecutionerInterface
    {
        JobsManager jobsManager;
        string userid;
        public JobExecutioner()
        {
            jobsManager = JobsManager.getInstance();
            System.Threading.Timer timer = new System.Threading.Timer(executeIfReady, null, 3000, 3000);

            if (File.Exists("omsloggeduser.dt"))
            {
                setUser(File.ReadAllText("omsloggeduser.dt"));
            }
        }

        public void jobHasBeenAdded()
        {
            if (jobsManager.load(userid)) executeIfReady(null);
        }
        //<summary>gets called by the desktop program as soon as the user gets authenticated,its part of the communication interface</summary>
        //<param name="user">the authenticated user</param>
        public void setUser(string user)
        {
            this.userid = user;
            ReceiversManager.getInstance().load(user);

            if (user != null && jobsManager.load(userid)) executeIfReady(null);


        }

        public void executeIfReady(object source)
        {
            List<Job> jobs = jobsManager.getAllJobs();
            foreach (Job job in jobs)
            {
                if (job.isReadForExecution())
                {   
                    job.execute();
                }

            }
        }
    }
}
