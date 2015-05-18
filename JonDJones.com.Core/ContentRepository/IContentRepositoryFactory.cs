using EPiServer;

namespace JonDJones.Com.Core.ContentRepository
{
    public interface IContentRepositoryFactory
    {
        IContentRepository GetContentRepository();
    }
}