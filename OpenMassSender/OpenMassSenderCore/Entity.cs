using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMassSenderCore
{

    public abstract class Entity
    {
        public Dictionary<string, Object> fields = new Dictionary<string, object>();
        public Object get(string name)
        {
            Object value;
            fields.TryGetValue(name,out value);
            return value;
        }
    }
}
