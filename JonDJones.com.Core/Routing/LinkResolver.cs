using System;
using EPiServer;
using EPiServer.Core;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;
using log4net;
using JonDJones.Com.Core.Routing;
using JonDJones.Com.Core.ContentRepository;

namespace JonDJones.Com.Core
{
    public class LinkResolver : ILinkResolver
    {
        private readonly static ILog Logger = LogManager.GetLogger(typeof(LinkResolver));

        private readonly Lazy<UrlResolver> _lazyUrlResolver;
        private readonly Lazy<IContentRepository> _lazyContentRepository;

        private string ResolveContentReferenceUrl(ContentReference contentReference)
        {
            if (ContentReference.IsNullOrEmpty(contentReference))
                return string.Empty;

            var result = string.Empty;
            try
            {
                result = _lazyUrlResolver.Value.GetUrl(contentReference) ?? string.Empty;
            }
            catch (Exception e)
            {
                Logger.ErrorFormat("Error attempting to resolve URL.\r\n{0}", e);
            }

            return result;
        }

        public LinkResolver(IUrlResolverFactory urlResolverFactory, IContentRepositoryFactory contentRepositoryFactory)
        {
            _lazyUrlResolver = new Lazy<UrlResolver>(urlResolverFactory.GetUrlResolver);
            _lazyContentRepository = new Lazy<IContentRepository>(contentRepositoryFactory.GetContentRepository);
        }

        public string ResolveUrl(string originalString)
        {
            return originalString;
        }

        public string ResolveUrl(IContent content)
        {
            return content == null ? string.Empty : ResolveContentReferenceUrl(content.ContentLink);
        }

        public string ResolveUrl(Url url)
        {
            if (url == null) return string.Empty;

            var parsedUrl = ResolveUrl(PageReference.ParseUrl(url.OriginalString));
            return string.IsNullOrWhiteSpace(parsedUrl) ? url.OriginalString : parsedUrl;
        }

        public string ResolveUrl(ContentReference contentReference)
        {
            if (ContentReference.IsNullOrEmpty(contentReference))
                return string.Empty;

            var content = _lazyContentRepository.Value.Get<IContent>(contentReference);
            return ResolveUrl(content);
        }

        public string ResolveUrl(LinkItem linkItem)
        {
            var result = linkItem.Href;
            var url = new UrlBuilder(linkItem.ToMappedLink());

            int id;
            if (int.TryParse(url.QueryCollection["id"], out id))
                result = ResolveUrl(new ContentReference(id));

            return result;
        }
    }
}