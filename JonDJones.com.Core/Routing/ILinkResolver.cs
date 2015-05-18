using EPiServer;
using EPiServer.Core;
using EPiServer.SpecializedProperties;

namespace JonDJones.Com.Core.Routing
{
    public interface ILinkResolver
    {
        string ResolveUrl(string originalString);

        string ResolveUrl(IContent content);

        string ResolveUrl(Url url);

        string ResolveUrl(ContentReference contentReference);

        string ResolveUrl(LinkItem linkItem);
    }
}