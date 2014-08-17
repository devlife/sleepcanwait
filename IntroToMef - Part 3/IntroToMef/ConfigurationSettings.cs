using System.ComponentModel.Composition;
using System.Configuration;

namespace IntroToMef
{
    internal class ConfigurationSettings
    {
        [Export("Timeout")]
        public int Timeout
        {
            get { return int.Parse(ConfigurationManager.AppSettings["Timeout"]); }
        }
    }
}