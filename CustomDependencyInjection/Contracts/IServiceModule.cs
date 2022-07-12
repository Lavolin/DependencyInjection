using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDependencyInjection.Contracts
{
    public interface IServiceModule
    {
        void CreateMapping<TInterface, TImplementation>();
        Type GetMapping<TInterface>();
        Type GetMapping(Type interfaceType);

        object GetInstance <TInterface>();

        void Configure();

    }
}
