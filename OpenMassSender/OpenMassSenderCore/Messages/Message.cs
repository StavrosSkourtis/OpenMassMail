using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace OpenMassSenderCore
{
    public partial class OpenMassSenderDBDataSet
    {
        public class MessageStatus { public static string ERROR = "ERROR", SUCCEED = "SUCCESS"; };

        partial class MessageRow
        {
            //<summary>The status of the message</summary>
            public string status;
            //<summary>A message can contain variables that are replaced upon send,for example $receiverName 
            //will be replaced with the receiver's name</summary>
            public Dictionary<string, string> replacableVariablesMap = new Dictionary<string, string>();
            //<summary>The message the message(no shit sherlock)</summary>
 
            public void setMessage(string message)
            {

                this.message = message;
                if (message.Contains(Wildcards.RECEIVER_FIRST_NAME) 
                    && replacableVariablesMap.ContainsKey(Wildcards.RECEIVER_FIRST_NAME)==false)
                    replacableVariablesMap.Add(Wildcards.RECEIVER_FIRST_NAME, null);
                if (message.Contains(Wildcards.RECEIVER_LAST_NAME)
                    && replacableVariablesMap.ContainsKey(Wildcards.RECEIVER_LAST_NAME) == false)
                    replacableVariablesMap.Add(Wildcards.RECEIVER_LAST_NAME, null);
            }
            private static Regex containsHtml = new Regex(@"$DATE(*)");
            private static Regex datePattern = new Regex(@"\$DATE\((.*?)\)");
            public string replaceWildCards(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
            {
                string ret = message;
                if (replacableVariablesMap.ContainsKey(Wildcards.RECEIVER_FIRST_NAME))
                    replacableVariablesMap.Add(Wildcards.RECEIVER_FIRST_NAME, receiver.first_name);
                if (replacableVariablesMap.ContainsKey(Wildcards.RECEIVER_LAST_NAME))
                    replacableVariablesMap.Add(Wildcards.RECEIVER_FIRST_NAME, receiver.last_name);
   
                foreach (KeyValuePair<string, string> entry in replacableVariablesMap)
                {
                    ret = ret.Replace(entry.Key, entry.Value);
                }
                if (message.Contains(Wildcards.DATE))
                {
                    foreach (Match m in datePattern.Matches(ret))
                    {
                        string datepattern = m.Value.Split('(')[1].Split(')')[0];
                        ret = ret.Replace(m.Value, DateTime.Now.ToString(datepattern));
                    }
                }
                return ret;
            }
            public void variablesListUpdated()
            {
                replaceVariables = "";
                foreach (KeyValuePair<string, string> entry in replacableVariablesMap)
                {
                    string var=entry.Key+";"+entry.Value;
                    replaceVariables+=(replaceVariables.Equals("")==false?"|"+var:var);
                }
                
            }
            public void variablesStringUpdated()
            {
                string[] vars = replaceVariables.Split('|');
                foreach(string var in vars){
                    replacableVariablesMap.Add(var.Split(';')[0], var.Split(';')[1]);
                }
            }
        }
    }
    public class Wildcards
    {
        public static string RECEIVER_FIRST_NAME = "$receiver_fname";
        public static string RECEIVER_LAST_NAME = "$receiver_lname";
        public static string DATE = "$date";

    }
}
