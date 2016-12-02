using System;
using System.Web;
using System.Web.Optimization;

namespace MakingItPretty
{

    public class NoCssTransform : IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            response.Content = String.Empty;
            response.ContentType = "text/css";
        }
    }

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            #region modernizr
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            #endregion

            #region Foundation Bundles

            bundles.Add(new StyleBundle("~/Content/foundation/css").Include(
                "~/Content/foundation/foundation.css",
                "~/Content/foundation/foundation.mvc.css",
                "~/Content/foundation/app.css"));

            bundles.Add(new Bundle("~/bundles/foundation").Include(
                "~/Scripts/foundation/fastclick.js",
                "~/Scripts/jquery.cookie.js",
                "~/Scripts/foundation/foundation.js",
                "~/Scripts/foundation/foundation.*",
                "~/Scripts/foundation/app.js"));

            #endregion

            #region customtransforms

            Bundle noCssBundle = new Bundle("~/bundles/nocss"
                , new NoCssTransform());
            noCssBundle.Include(
                       "~/Content/foundation/foundation.css",
                       "~/Content/foundation/foundation.mvc.css",
                       "~/Content/foundation/app.css");
            bundles.Add(noCssBundle);

            new StyleBundle("~/Content/foundation/css").Include(
                       "~/Content/foundation/foundation.css",
                       "~/Content/foundation/foundation.mvc.css",
                       "~/Content/foundation/app.css");
            #endregion

            #region bundle that does work

            bundles.Add(new Bundle("~/Scripts/foundation").Include(
           "~/Scripts/foundation/fastclick.js",
           "~/Scripts/jquery.cookie.js",
           "~/Scripts/foundation/foundation.js",
           "~/Scripts/foundation/foundation.*",
           "~/Scripts/foundation/app.js"));
            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}








