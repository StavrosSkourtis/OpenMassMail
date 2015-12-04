using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace OpenMassSenderCore.Utils
{
    class SecurityUtils
    {

        public static string SHA256(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }

    class DatabaseUtils
    {
        //<TODO>fix the mappath error</TODO>
        public static string CONNECTION_STRING = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OpenMassSenderDB.accdb";
     //   public static string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0; " +"Data Source=" + Microsoft.SqlServer.Server.MapPath("~/OpenMassSender.accdb");
    }
}
