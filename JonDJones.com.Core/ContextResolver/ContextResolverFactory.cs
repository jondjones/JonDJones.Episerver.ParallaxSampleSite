using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JonDJones.Com.Core.ContextResolver
{
    public class ContextResolverFactory : IContextResolverFactory
    {
        internal Injected<IContextResolver> ContextResolver;

        public IContextResolver GetContextResolver()
        {
            return ContextResolver.Service;
        }
    }
}