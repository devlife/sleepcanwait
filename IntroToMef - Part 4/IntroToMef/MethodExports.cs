using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace IntroToMef
{
    internal class MethodExports
    {
        [Import(typeof(Action<string>))]
        public Action<string> MessageSender { get; set; }

        internal void Run()
        {
            Compose();
            MessageSender("Message being sent from MethodExports class");
        }

        private void Compose()
        {
            var container = new CompositionContainer();

            // In this example we will use the MessageSender Part to fill the catalog
            container.ComposeParts(this, new ConsoleMessageSender());
        }
    }
}