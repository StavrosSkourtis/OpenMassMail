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
        //<sumarry>the logic for loading all the receivers that the user has added(from a db local/online)</sumarry>
        //<param name="user">The user to add</param>
        //<returns>returns true if new jobs has been added to the jobs list</returns>
        public bool load(User user)
        {

            return false;
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
