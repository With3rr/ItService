﻿using ITService.Domain;
using System.Threading.Tasks;
using Autofac;

namespace ITService.Infrastructure
{
    public class AutofacDependencyResolver : IDependencyResolver
    {
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacDependencyResolver(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }
        public T ResolveOrDefault<T>() where T : class
        {
            return _lifetimeScope.ResolveOptional<T>();
        }
    }
}
