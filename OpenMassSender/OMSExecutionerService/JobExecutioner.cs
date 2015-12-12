using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Jobs;
using System.IO;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.Threading;
using OpenMassSenderCore;


namespace OMSExecutionerService
{
    //<summary>implementation of the JobExecutioner which will execute jobs when they will be ready, implements the interface
    //descirbed at CoreProject->Jobs->JobExecutionerInterface</summary>
    public class JobExecutioner : JobExecutionerInterface
    {
        string userid;
        public JobExecutioner()
        {
        
            if (File.Exists("omsloggeduser.dt"))
            {
                setUser(File.ReadAllText("omsloggeduser.dt").Split('|')[2]);
            }

            (new Thread(() =>
            {
                while (true)
                {
                    executeIfReady();
                    Thread.Sleep(2000);
                }
            })).Start();
        }
        //<summary>notify the executioner that a new job has been added</summary>
        public void jobHasBeenAdded()
        {
            executeIfReady();
        }
        //<summary>gets called by the desktop program as soon as the user gets authenticated,its part of the communication interface</summary>
        //<param name="user">the authenticated user</param>
        public void setUser(string user)
        {
            this.userid = user;
            if (user != null) executeIfReady();
        }
        //<summary>check if any of the pending/scheduled jobs are ready for execution</summary>
        public void executeIfReady()
        {
            if (UserTableAdapter.getInstance().userid == null) return;
            try
            {
                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.JobRow job in JobTableAdapter.getInstance().GetDataByUser(Int32.Parse(UserTableAdapter.getInstance().userid)))
                {
                    if (job.isReadForExecution())
                    {
                        job.execute();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.log("error", ex.Message);
            }

        }
    }
}
