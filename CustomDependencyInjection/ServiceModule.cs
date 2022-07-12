using CustomDependencyInjection.Contracts;
using System;
using System.Collections.Generic;

namespace CustomDependencyInjection
{
    public abstract class ServiceModule : IServiceModule
    {
        Dictionary<Type, Type> mappings;
        Dictionary<Type, object> instances;

        public ServiceModule()
        {
            this.mappings = new Dictionary<Type, Type>();
            this.instances = new Dictionary<Type, object>();
            Configure();
        }

        public void CreateMapping<TInterface, TImplementation>()
        {
            mappings[typeof(TInterface)] = typeof(TImplementation);
        }

        public abstract void Configure();

        public object GetInstance<TInterface>()
        {
            if (instances.ContainsKey(typeof(TInterface)))
            {
                return instances[typeof(TInterface)];
            }

            return null;
        }

        public Type GetMapping<TInterface>()
        {
            return mappings[typeof(TInterface)];
        }

        public Type GetMapping(Type interfaceType)
        {
            return mappings[interfaceType];
        }
    }
}
