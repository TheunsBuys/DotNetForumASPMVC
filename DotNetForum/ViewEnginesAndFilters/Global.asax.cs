using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Razor;
using System.Web.Routing;
using System.Web.WebPages;
using ViewEngines.App_Start;
using ViewEngines.Controllers;
using WebApplication1;

namespace ViewEngines
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            System.Web.Mvc.ViewEngines.Engines.Clear();
            System.Web.Mvc.ViewEngines.Engines.Add(new MyViewEngine());






            //        #region build providers and extensions
            //      webconfig, viewengines x2
            System.Web.Razor.RazorCodeLanguage.Languages.Add(
    "xxhtml", new CSharpRazorCodeLanguage());

            WebPageHttpHandler.RegisterExtension("xxhtml");
            //        #endregion
        }
    }
}
