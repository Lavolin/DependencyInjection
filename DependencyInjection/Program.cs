using CustomDependencyInjection;
using DependencyInjection.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            DICustomConfig customConfig = new DICustomConfig();
            Injector injector = new Injector();
            injector.ServiceModule = customConfig;
            // var logger = injector.Create<SpecialLogger>();

            Engine engine = injector.Create<Engine>();

            //logger.Log("Hi");
            engine.Start();
            Console.WriteLine();


            //return;
            //IServiceProvider serviceProvider = new DIConfigurator().Configure();

            //Engine engine = serviceProvider.GetRequiredService<Engine>();

            //engine.Start();
        }
    }
}
