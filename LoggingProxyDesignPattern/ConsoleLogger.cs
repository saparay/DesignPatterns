using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxyDesignPattern
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}
