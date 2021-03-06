using System.Web;
using System.Web.Optimization;

namespace ViewEngines
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #region bootstrp bundles

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            "~/Scripts/bootstrap.js",
            "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/bundles").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            
            #endregion

            #region Foundation Bundles

            bundles.Add(new StyleBundle("~/Content/foundation/css").Include(
                "~/Content/foundation/foundation.css",
                "~/Content/foundation/foundation.mvc.css",
                "~/Content/foundation/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                "~/Scripts/foundation/fastclick.js",
                "~/Scripts/jquery.cookie.js",
                "~/Scripts/foundation/foundation.js",
                "~/Scripts/foundation/foundation.*",
                "~/Scripts/foundation/app.js"));

            #endregion
        }
    }
}