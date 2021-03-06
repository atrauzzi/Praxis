using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Praxis.Extensions
{
    public static class ObjectExtensions
    {
        // ToDo: domain-tool
        public static T Merge<T>(this T target, T source)
        {
            target.GetType()
                .GetProperties()
                .Where(p => p.CanWrite && p.CanRead)
                .Select(p => 
                    new KeyValuePair<PropertyInfo, object>(p, p.GetValue(source, null)))
                .Where(tp => tp.Value != null)
                .ToList()
                .ForEach(p => p.Key
                    .SetValue(target, p.Value, null));

            return target;
        }
    }
}