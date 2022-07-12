using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Logger : ILogger
    {
        private DateTime dateToday;
        public Logger(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }
        public void Log(string log)
        {
            Console.WriteLine($"{dateToday} {log}");
        }
    }
}
