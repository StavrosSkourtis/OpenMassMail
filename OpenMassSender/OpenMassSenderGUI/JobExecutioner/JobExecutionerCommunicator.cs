using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMassSenderCore.Jobs;
using System.ServiceModel;

namespace OpenMassSenderGUI.JobExecutioner
{
    class JobExecutionerCommunicator{
        public JobExecutionerInterface jobExecutioner;
        private JobExecutionerCommunicator() {
            ChannelFactory<JobExecutionerInterface> pipeFactory =
                 new ChannelFactory<JobExecutionerInterface>(
                     new NetNamedPipeBinding(),
                     new EndpointAddress("net.pipe://localhost/OMSJobExecutioner")
                 );
            this.jobExecutioner=pipeFactory.CreateChannel();
        }
        private static JobExecutionerCommunicator instance;
        public static JobExecutionerCommunicator getInstance()
        {
            if (instance == null) instance = new JobExecutionerCommunicator();
            return instance;
        }

    }
}
