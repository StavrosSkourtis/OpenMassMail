using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenMassSenderCore
{
    public class Logger
    {
        public static List<LogEntry> logs = new List<LogEntry>();
        private static void log(string category,string text)
        {
            logs.Add(new LogEntry(category, text));
            if (category.Equals("ERROR"))
            {
                openLogger();
            }
        }
        public static void log(string text)
        {
            log("LOG", text);
        }
        public static void error(string text)
        {
            log("ERROR", text);
        }
        public static void debug(string text)
        {
            log("DEBUG", text);
        }

        public static Form logWindow = null;
        public static void openLogger()
        {
            if (logWindow != null)
            {
                logWindow.Show();
            }
        }
    }
    public class LogEntry
    {
        public bool consumed = false;
        public string tag, text;
        public DateTime date;
        public LogEntry(string tag, string text)
        {
            date = System.DateTime.Now;
            this.tag = tag;
            this.text = text;
        }
    }
}
