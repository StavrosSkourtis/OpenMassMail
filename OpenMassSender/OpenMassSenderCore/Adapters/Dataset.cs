using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore
{
    public partial class OpenMassSenderDBDataSet
    {
        private static OpenMassSenderDBDataSet instance;
        public static OpenMassSenderDBDataSet getInstance()
        {
            if (instance == null) instance = new OpenMassSenderDBDataSet();
            return instance;
        }
    }
}
