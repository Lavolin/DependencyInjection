using CustomDependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomDependencyInjection
{
    public class Injector
    {

        public IServiceModule ServiceModule { get; set; }

        private object Create(Type typeToCreate)
        {
            var injector = typeof(Injector).GetMethod("Create");
            var createMethod = injector.MakeGenericMethod(typeToCreate);
            return createMethod.Invoke(this, null);
        }

        public TClass Create<TClass>()
        {
            ConstructorInfo[] constructors = typeof(TClass).GetConstructors();
            TClass instance = default(TClass);

            foreach (var constructor in constructors)
            {
                object[] instances = new object[constructor.GetParameters().Length];
                int index = 0;

                ParameterInfo[] parameters = constructor.GetParameters();

                foreach (var parameter in parameters)
                {
                    var parameterInstance = ServiceModule.GetInstance<TClass>();
                    if (parameterInstance == null)
                    {
                        Type parameterImplementationType = ServiceModule.GetMapping(parameter.ParameterType);

                        parameterInstance = Create(parameterImplementationType);
                    }

                    instances[index++] = parameterInstance;
                }

                instance = (TClass)Activator.CreateInstance(typeof(TClass), instances);

            }

            if (instance == null)
            {
                instance = (TClass)Activator.CreateInstance(typeof(TClass));

            }

            return instance;
        }
    }
}
