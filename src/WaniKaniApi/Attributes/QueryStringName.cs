using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaniKaniApi.Attributes
{
    public class QueryStringNameAttribute : Attribute
    {
        public QueryStringNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
