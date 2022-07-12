using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class ConsoleReader : IReader
    {
        private ILogger logger;
        public ConsoleReader(ILogger logger)
        {
            this.logger = logger;
        }
        public string Read()
        {
            logger.Log("Reading");
            return Console.ReadLine();
        }
    }
}
