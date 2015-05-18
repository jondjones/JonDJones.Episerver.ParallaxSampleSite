using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace JonDJones.Com.Core.Routing
{
    public class UrlResolverFactory : IUrlResolverFactory
    {
        internal Injected<UrlResolver> UrlResolver;

        public UrlResolver GetUrlResolver()
        {
            return UrlResolver.Service;
        }
    }
}