using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace IntroToMef
{
    /// <summary>
    /// This class demonstrates the ability to import a property.
    /// </summary>
    public class PropertyExports
    {
        /// <summary>
        /// The value for the Timeout property is exported by ConfigurationSettings.cs
        /// </summary>
        [Import("Timeout")]
        public int Timeout { get; set; }

        public void Run()
        {
            Compose();
            Console.WriteLine("The imported Timeout value is: {0}", Timeout);
        }

        private void Compose()
        {
            var container = new CompositionContainer(new AssemblyCatalog(typeof(PropertyExports).Assembly));
            container.ComposeParts(this);
        }
    }
}