using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicLoaderContracts
{
    public enum Policy
    {
        Transient,
        Singelton
    }

    public class LoaderAttribute : Attribute
    {
        public Type InterfaceType { get; private set; }
        public Type ImplementationType { get; private set; }
        public Policy Policy { get; set; }

        public LoaderAttribute(Type interfaceType, Type implementationType, Policy policy)
        {
            InterfaceType = interfaceType;
            ImplementationType = implementationType;
            Policy = policy;
        }
    }
}