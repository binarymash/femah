﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Femah.Core.Configuration
{
    public class FluentAssemblyConfiguration : FemahFluentConfiguration
    {
        public FluentAssemblyConfiguration FromAssembly(Assembly assembly)
        {
     //       this._config.Assemblies.Add(assembly);
            return this;
        }

        public FluentAssemblyConfiguration FromAssemblyContaining<T>()
        {
            return this.FromAssembly(typeof(T).Assembly);
        }

        public FluentAssemblyConfiguration FromThisAssembly()
        {
            return this.FromAssembly(Assembly.GetCallingAssembly());
        }
    }

    public class FemahConfiguration
    {
        public FemahConfiguration()
        {
            CustomSwitchTypes = new List<Type>();
            StandardSwitchTypes = new List<Type>();
        }

        public IFemahContextFactory ContextFactory { get; set; }
        public IFeatureSwitchProvider Provider { get; set; }
        public List<Type> StandardSwitchTypes { get; set; }
        public List<Type> CustomSwitchTypes { get; set; }
        public Type FeatureSwitchEnumType { get; set; }
    }
}
