using System;
using System.ComponentModel.Composition;

namespace IntroToMef
{
    /// <summary>
    /// This class simply shows how to export a method
    /// </summary>
    public class ConsoleMessageSender
    {
        [Export(typeof(Action<string>))]
        public void Send(string message)
        {
            Console.WriteLine("ConsoleMessageSender: " + message);
        }
    }
}
