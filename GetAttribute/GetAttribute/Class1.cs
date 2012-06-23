using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAttribute
{
    public class Class1
    {
        public void DoSomething()
        {
            var customerType = typeof(Customer);
            ConfigurationAttribute configAttr = (ConfigurationAttribute)customerType.GetCustomAttributes(typeof(ConfigurationAttribute), false).SingleOrDefault();
        }

        public void DoSomethingElse()
        {
            ConfigurationAttribute configAttr = typeof(Customer).GetAttribute<ConfigurationAttribute>();
        }
    }
}
