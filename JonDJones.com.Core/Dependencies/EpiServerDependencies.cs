using System;
using EPiServer;
using JonDJones.Com.Core.Routing;
using JonDJones.Com.Core.ContentRepository;
using JonDJones.Com.Core.ContextResolver;
using EPiServer.Core;

namespace JonDJones.Com.Core
{
    public class EpiServerDependencies : IEpiServerDependencies
    {

        private readonly Lazy<IContentRepository> _contentRepository;
        private readonly Lazy<ILinkResolver> _linkResolver;
        private readonly Lazy<IContextResolver> _contextResolver;

        public EpiServerDependencies(
            IContentRepositoryFactory contentRepositoryFactory,
            ILinkResolverFactory linkResolverFactory,
            IContextResolverFactory contextResolverFactory)
        {
            _contentRepository = new Lazy<IContentRepository>(contentRepositoryFactory.GetContentRepository);
            _linkResolver = new Lazy<ILinkResolver>(linkResolverFactory.GetLinkResolver);
            _contextResolver = new Lazy<IContextResolver>(contextResolverFactory.GetContextResolver);
        }

        public ILinkResolver LinkResolver
        {
            get { return _linkResolver.Value; }
        }

        public IContentRepository ContentRepository
        {
            get { return _contentRepository.Value; }
        }

        public IContextResolver ContextResolver
        {
            get { return _contextResolver.Value; }
        }

        public PageData CurrentPage { get; set; }
    }
}