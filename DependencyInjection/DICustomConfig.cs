using CustomDependencyInjection;
using CustomDependencyInjection.Contracts;
using DependencyInjection.Contracts;

namespace DependencyInjection
{
    public class DICustomConfig : ServiceModule
    {
        public override void Configure()
        {
            CreateMapping<IReader, ConsoleReader>();
            CreateMapping<Engine, Engine>();
            CreateMapping<ILogger, SpecialLogger>();
        }
    }
}
