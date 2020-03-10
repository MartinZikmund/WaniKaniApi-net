using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    internal abstract class FilterBase : IFilter
    {
        internal string GetPropertyQueryString(PropertyInfo propertyInfo)
        {
            var value = propertyInfo.GetValue(this);
            var name = propertyInfo.GetCustomAttribute<QueryStringNameAttribute>().Name;
            
        }
    }
}
