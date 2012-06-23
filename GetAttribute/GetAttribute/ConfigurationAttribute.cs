using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAttribute
{
    public class ConfigurationAttribute : Attribute
    {
        public string ElementName { get; private set; }

        public ConfigurationAttribute(string elementName)
        {
            ElementName = elementName;
        }
    }
}
