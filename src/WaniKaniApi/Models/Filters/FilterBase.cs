using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Attributes;

namespace WaniKaniApi.Models.Filters
{
    public abstract class FilterBase : IFilter
    {
        public string BuildQueryString()
        {
            var properties = GetType().GetProperties();
            List<string> queryStringParts = new List<string>();
            foreach (var property in properties)
            {
                var queryStringPart = GetPropertyQueryString(property);
                if (!string.IsNullOrEmpty(queryStringPart))
                {
                    queryStringParts.Add(queryStringPart);
                }
            }
            if (queryStringParts.Count > 0)
            {
                return $"?{string.Join("&", queryStringParts)}";
            }
            else
            {
                return string.Empty;
            }
        }

        internal string GetPropertyQueryString(PropertyInfo propertyInfo)
        {
            var value = propertyInfo.GetValue(this);
            var attribute = propertyInfo.GetCustomAttribute<QueryStringNameAttribute>();
            if (attribute == null || value == null)
            {
                return string.Empty;
            }
            else
            {
                var name = attribute.Name;
                return $"{name}={SerializeValue(value)}";
            }
        }

        private string SerializeValue(object value)
        {
            switch (value)
            {
                case IEnumerable enumerable:
                    {
                        return string.Join(",", enumerable.OfType<object>().Select(o=>o.ToString().ToLowerInvariant()));
                    }
                case DateTimeOffset dateTimeOffset:
                    {
                        return dateTimeOffset.DateTime.ToString("o");
                    }
                default:
                    return Uri.EscapeDataString(value.ToString());
            }
        }
    }
}
