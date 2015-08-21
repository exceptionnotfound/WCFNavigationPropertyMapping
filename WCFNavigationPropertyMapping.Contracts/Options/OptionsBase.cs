using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WCFNavigationPropertyMapping.Contracts.Attributes;

namespace WCFNavigationPropertyMapping.Contracts.Options
{
    [DataContract]
    public abstract class OptionsBase
    {
        public List<string> GetSelectedOptions()
        {
            List<string> names = new List<string>();
            var type = GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo info in properties)
            {
                bool value = (bool)info.GetValue(this);
                if (info.PropertyType == typeof(bool) && value)
                {
                    NavigationPropertyAttribute attribute = (NavigationPropertyAttribute)info.GetCustomAttribute(typeof(NavigationPropertyAttribute));
                    names.Add(attribute.NavigationPropertyName);
                }
            }
            return names;
        }
    }
}
