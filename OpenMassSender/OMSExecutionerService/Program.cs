using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using OpenMassSenderCore.Jobs;

namespace OMSExecutionerService
{
    static class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(  typeof(JobExecutioner),
                 new Uri[]{new Uri("net.pipe://localhost")}
                 ))
                  {
                        host.AddServiceEndpoint(
                            typeof(JobExecutionerInterface),
                            new NetNamedPipeBinding(),
                            "OMSJobExecutioner"
                        );

                        host.Open();

                        new JobExecutioner();

                        Console.WriteLine("Job executioner is running");

                    }
               }
    }
}
