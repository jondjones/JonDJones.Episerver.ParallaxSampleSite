using EPiServer.Web.Routing;

namespace JonDJones.Com.Core.ContextResolver
{
    public interface IContextResolverFactory
    {
        IContextResolver GetContextResolver();
    }
}