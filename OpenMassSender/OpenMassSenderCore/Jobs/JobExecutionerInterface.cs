using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using OpenMassSenderCore.Users;

namespace OpenMassSenderCore.Jobs
{
    [ServiceContract]
    public interface JobExecutionerInterface
    {
        //<summary>method for notifing the executioner service that a new job has been added</summary>
        [OperationContract]
        void jobHasBeenAdded();
        void setUser(string user);
    }
}
