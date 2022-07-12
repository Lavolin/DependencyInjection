﻿using DependencyInjection.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public class DIConfigurator
    {
        public IServiceProvider Configure()
        {
            ServiceCollection collection = new ServiceCollection();

            //collection.AddSingleton(typeof(IReader), typeof(ConsoleReader));
            collection.AddSingleton<IReader, ConsoleReader>();
            collection.AddSingleton<Engine, Engine>();
            collection.AddSingleton<ILogger, Logger>();
            collection.AddTransient(typeof(DateTime),(IServiceProvider provider) =>
            {
                return DateTime.Now;
            });

            var serviceProvider = collection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
