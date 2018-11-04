using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHW
{
    public class RoleInfoAttribute : System.Attribute
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public RoleInfoAttribute()
        { }

        public RoleInfoAttribute(string name)
        {
            Name = name;
        }
    }
}
