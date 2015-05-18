using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer;
using EPiServer.Core;
using EPiServer.DataAccess;
using EPiServer.Framework;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Security;
using JonDJones.Com.Core;

namespace JonDJones.Com.App_Code
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DataInitializationModule : IInitializableModule
    {
        internal Injected<IEpiServerDependencies> EpiServerDependencies;

        internal Injected<ContentAssetHelper> ContentAssetHelper;

        public void Initialize(InitializationEngine context)
        {
            context.InitComplete += InitCompleteHandler;
        }

        public void Preload(string[] parameters)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private void InitCompleteHandler(object sender, EventArgs e)
        {
            var fixturesCode = new FixturesCode(EpiServerDependencies.Service, ContentAssetHelper.Service);

            var startPageReference = fixturesCode.CreateHomePage("HomePage");
            var contentPageReference = fixturesCode.CreateContentPage("Content Page");

            if (contentPageReference != null)
                fixturesCode.AddContentArea(contentPageReference);
        }
    }
}