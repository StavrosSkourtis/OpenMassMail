using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace OpenMassSenderCore.Jobs
{
    [ServiceContract]
    public interface JobExecutionerInterface
    {
        //<summary>method for notifing the executioner service that a new job has been added</summary>
        [OperationContract]
        void jobHasBeenAdded();
    }
}
