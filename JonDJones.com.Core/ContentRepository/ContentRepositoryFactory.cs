using EPiServer;
using EPiServer.ServiceLocation;

namespace JonDJones.Com.Core.ContentRepository
{
    public class ContentRepositoryFactory : IContentRepositoryFactory
    {
        internal Injected<IContentRepository> ContentRepositoryService;

        public IContentRepository GetContentRepository()
        {
            return ContentRepositoryService.Service;
        }
    }
}