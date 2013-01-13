using System;

namespace IntroToMef
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var host = new HostMefInAnApplication();
            host.Run();

            Console.Read();
        }
    }
}