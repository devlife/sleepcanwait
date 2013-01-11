using System;

namespace IntroToMef
{
    public class SomeRandomLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("From SomeRandomLogger: {0}", message);
        }
    }
}