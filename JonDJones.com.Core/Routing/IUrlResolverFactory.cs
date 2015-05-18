using EPiServer.Web.Routing;

namespace JonDJones.Com.Core.Routing
{
    public interface IUrlResolverFactory
    {
        UrlResolver GetUrlResolver();
    }
}