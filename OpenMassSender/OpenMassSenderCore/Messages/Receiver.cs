using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace OpenMassSenderCore
{
    public partial class OpenMassSenderDBDataSet
    {
        partial class ReceiverRow
        {
            //<summary>The status of the message</summary>
            public string status;
            //<summary>A message can contain variables that are replaced upon send,for example $receiverName 
            //will be replaced with the receiver's name</summary>
            public Dictionary<string, string> replacableVariablesMap = new Dictionary<string, string>();
            //<summary>The message the message(no shit sherlock)</summary>


            public Dictionary<string, string> getMetadataList()
            {
                Dictionary<string,string> data = new Dictionary<string,string>();

                string[] mdata = this.metadata.Split(';');
                foreach (string s in mdata)
                {
                    try
                    {
                        data.Add(s.Split('=')[0], s.Split('=')[1]);
                    }
                    catch (Exception ex) { }
                }
                return data;
            }
        }
    }
}
