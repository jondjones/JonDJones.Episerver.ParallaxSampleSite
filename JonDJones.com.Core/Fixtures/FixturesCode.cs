
using EPiServer.Core;
using EPiServer.DataAccess;
using EPiServer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JonDJones.Com.Core.Pages;
using EPiServer.ServiceLocation;

namespace JonDJones.Com.Core
{
    public class FixturesCode
    {
        private IEpiServerDependencies _epiServerDependencies;

        private ContentAssetHelper _contentAssetHelper;

        public FixturesCode(IEpiServerDependencies epiServerDependencies, ContentAssetHelper contentAssetHelper)
        {
            _epiServerDependencies = epiServerDependencies;
            _contentAssetHelper = contentAssetHelper;

        }

        public ContentReference CreateContentPage(string pageName)
        {
            try
            {
                var existingContentPage =
                    _epiServerDependencies.ContentRepository.GetChildren<ContentPage>(
                    _epiServerDependencies.ContextResolver.RootPage);

                if (existingContentPage != null && existingContentPage.Where(x => x.PageName == pageName).Any())
                    return null;
            }
            catch(Exception ex)
            {
                return null;
            }

            var contentPage =
                _epiServerDependencies.ContentRepository.GetDefault<ContentPage>
                (_epiServerDependencies.ContextResolver.RootPage);

            contentPage.Name = pageName;
            contentPage.PageTitle = pageName;
            contentPage.SeoTitle = pageName;
            contentPage.Keywords = pageName;
            contentPage.Description = new XhtmlString(pageName);
            contentPage.Author = pageName;

            return _epiServerDependencies.ContentRepository.Save(contentPage, SaveAction.Publish, AccessLevel.NoAccess);
        }

        public ContentReference AddContentArea(ContentReference contentReference)
        {
            var contentArea = new ContentArea { Items = { new ContentAreaItem { ContentLink = contentReference } } };

            var contentPage =
                _epiServerDependencies.ContentRepository.Get<ContentPage>
                (contentReference);

            contentPage.MainContentArea = contentArea;

            return _epiServerDependencies.ContentRepository.Save(contentPage, SaveAction.Publish, AccessLevel.NoAccess);
 
        }

        public ContentReference CreateHomePage(string pageName)
        {
            try
            {
                var existingContentPage =
                    _epiServerDependencies.ContentRepository.GetChildren<StartPage>(
                    _epiServerDependencies.ContextResolver.RootPage);

                if (existingContentPage != null && existingContentPage.Where(x => x.PageName == pageName).Any())
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }

            var contentPage =
                _epiServerDependencies.ContentRepository.GetDefault<StartPage>
                (_epiServerDependencies.ContextResolver.RootPage);

            contentPage.Name = pageName;
            contentPage.PageTitle = pageName;
            contentPage.SeoTitle = pageName;
            contentPage.Keywords = pageName;
            contentPage.Description = new XhtmlString(pageName);
            contentPage.Author = pageName;

            contentPage.MainTitle = "Your Favorite Source of Free Bootstrap Themes";
            contentPage.MainDescription = new XhtmlString("Start Bootstrap can help you build better websites using the Bootstrap CSS framework! Just download your template and start going, no strings attached!");
            

            return _epiServerDependencies.ContentRepository.Save(contentPage, SaveAction.Publish, AccessLevel.NoAccess);
        }
    }
}