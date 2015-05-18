using EPiServer.ServiceLocation;

namespace JonDJones.Com.Core.Routing
{
    public class LinkResolverFactory : ILinkResolverFactory
    {
        internal Injected<ILinkResolver> LinkResolver;

        public ILinkResolver GetLinkResolver()
        {
            return LinkResolver.Service;
        }
    }
}