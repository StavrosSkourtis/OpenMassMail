using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.IO;
using OpenMassSenderCore;
using System.ServiceProcess;
using OMSExecutionerService;

namespace OpenMassSenderGUI
{
    public static class Program
    {
        private static OMSExecutionerService.JobExecutioner localExecutioner;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            /*Check if the executioner service is running*/
            bool isServiceRunning=false;
            foreach (ServiceController service in ServiceController.GetServices())
            {
                if(service.ServiceName.Equals(OMSService.SERVICE_NAME)){
                    isServiceRunning=true;
                }
            } 
            /*if the service is not running,create a local executioner*/
            if(!isServiceRunning){
                localExecutioner=new OMSExecutionerService.JobExecutioner();
            }

            Application.Run(MainForm.Instance);
            //Application.Run(new Testing());
        }
        //<summary>notify the executioner for a new job</summary>
        public static void notifyTheExecutioner()
        {
            if (localExecutioner != null) localExecutioner.jobHasBeenAdded();
        }
    }
}
