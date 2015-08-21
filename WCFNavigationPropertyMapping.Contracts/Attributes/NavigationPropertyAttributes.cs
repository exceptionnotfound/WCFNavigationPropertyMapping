using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFNavigationPropertyMapping.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NavigationPropertyAttribute : Attribute
    {
        protected string _navigationPropertyName { get; set; }

        public string NavigationPropertyName
        {
            get
            {
                return _navigationPropertyName;
            }
            set
            {
                _navigationPropertyName = value;
            }
        }

        public NavigationPropertyAttribute()
        {
            _navigationPropertyName = string.Empty;
        }

        public NavigationPropertyAttribute(string name)
        {
            _navigationPropertyName = name;
        }
    }
}
