using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace JonDJones.Com
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);
        }
    }
}