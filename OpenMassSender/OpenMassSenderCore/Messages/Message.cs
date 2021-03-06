﻿using System;
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
                if (message.Contains(Wildcards.META)
                    && replacableVariablesMap.ContainsKey(Wildcards.META) == false)
                    replacableVariablesMap.Add(Wildcards.META, null);
                if (message.Contains(Wildcards.DATE)
                    && replacableVariablesMap.ContainsKey(Wildcards.DATE) == false)
                    replacableVariablesMap.Add(Wildcards.DATE, null);
            }

            public string replaceWildCards(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow receiver)
            {
                Regex datePattern = new Regex(@"\$DATE\((.*?)\)");
                Regex medatadataPattern = new Regex(@"\$META\((.*?)\)");

                string ret = message;
                if (message.Contains(Wildcards.DATE))
                {
                    foreach (Match m in datePattern.Matches(ret))
                    {
                        string datepattern = m.Value.Split('(')[1].Split(')')[0];
                        ret = ret.Replace(m.Value, DateTime.Now.ToString(datepattern));
                    }
                }
                if (message.Contains(Wildcards.META) && receiver!=null)
                {

                    Dictionary<string, string> md = receiver.getMetadataList();
                    foreach (Match m in medatadataPattern.Matches(ret))
                    {
                        string datepattern = m.Value.Split('(')[1].Split(')')[0];
                        string value=null;
                        try
                        {
                            md.TryGetValue(datepattern,out value);
                        }
                        catch (Exception ex) { }
                        Console.WriteLine("replacing:" + m.Value + "  with:" + datepattern);
                        if (value != null) ret = ret.Replace(m.Value, value);
                    }
                }
                return ret;
            }
            public void variablesListUpdated()
            {
                replaceVariables = "";
                foreach (KeyValuePair<string, string> entry in replacableVariablesMap)
                {
                    string var=entry.Key+"="+entry.Value;
                    replaceVariables+=(replaceVariables.Equals("")==false?";"+var:var);
                }
                
            }
            public void variablesStringUpdated()
            {
                string[] vars = replaceVariables.Split(';');
                foreach(string var in vars){
                    replacableVariablesMap.Add(var.Split('=')[0], var.Split('=')[1]);
                }
            }
        }
    }
    public class Wildcards
    {
        public static string DATE = "$DATE";
        public static string META = "$META";
    }
}
