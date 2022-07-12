using DependencyInjection.Contracts;
using System;


namespace DependencyInjection
{
    internal class SpecialLogger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine($"SpecialLogger at your service!! {log}");
        }
    }
}
