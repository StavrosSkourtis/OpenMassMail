using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Receivers;
using OpenMassSenderCore.Jobs;
using OpenMassSenderCore.Users;

namespace OpenMassSenderCore.Managers
{
    //<summary>A job is a sheduled/pending or already executed action of whatever type(mail,sms)</summary>
    public class JobsManager
    {
        
        //<summary>A list with all the jobs</summary>
        private List<Job> jobs = new List<Job>();
        private string userid;
        public bool setUserID(string user)
        {
            this.userid = user;
            return true;
        }
        //<sumarry>Adds a new job</summary>
        //<param name="job">The job to add</param>
        public void add(Job job)
        {

        }
        //<sumarry>Returns a list with all the jobs</summary>
        public List<Job> getAllJobs()
        {
            return jobs;
        }

        private static JobsManager instance;
        private JobsManager() { }
        public static JobsManager getInstance()
        {
            if (instance == null)instance = new JobsManager();
            return instance;
        }
    }
}
