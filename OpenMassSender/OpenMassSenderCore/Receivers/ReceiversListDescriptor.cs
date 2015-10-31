using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore.Receivers
{
    //<summary>a job instead of having a list with all the receivers that where a match to the query upon the job's creation
    //it has a ReceiversListDescriptor(receiversGroup,query), this way if the job is repeatable and new receivers have been added
    //to a specific group, at the time of the next job execution the job's receivers will contain the newly added recivers
    //,also in the case we want to added an unsucribe button to the email, we could just remove the receiver from the group</summary>
    public class ReceiversListDescriptor
    {
        public string group, query;
    }
}
