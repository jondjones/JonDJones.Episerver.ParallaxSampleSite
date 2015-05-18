using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StructureMap;
using JonDJones.Com.Core.ContentRepository;
using JonDJones.Com.Core.Routing;
using JonDJones.Com.Core.ContextResolver;
using JonDJones.Com.Core;
using JonDJones.com.Core.Helpers;

namespace JonDJones.Com.App_Code
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class StructureMapSetUp : IConfigurableModule
    {
        private IContainer _container;

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
            _container = context.Container;
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            container.For<IContentRepositoryFactory>().Use<ContentRepositoryFactory>();
            container.For<ILinkResolverFactory>().Use<LinkResolverFactory>();
            container.For<IContextResolverFactory>().Use<ContextResolverFactory>();

            container.For<IBlockHelper>().Use<BlockHelper>();

            container.For<ILinkResolver>().Use(ctx => new LinkResolver(
                new UrlResolverFactory(),
                new ContentRepositoryFactory()));

            container.For<IContextResolver>().Use(ctx => new ContextResolver());

            container.For<IEpiServerDependencies>()
                .Use(ctx => new EpiServerDependencies(
                new ContentRepositoryFactory(),
                new LinkResolverFactory(),
                new ContextResolverFactory()
                ));
        }
    }
}