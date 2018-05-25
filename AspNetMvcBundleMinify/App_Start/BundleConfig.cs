using System.Web.Optimization;

namespace AspNetMvcBundleMinify
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptBundle = new OrderedScriptBundle("~/bundles/scripts")
                                    .Include("~/Scripts/jquery-{version}.js")
                                    .Include("~/Scripts/jquery.validate*")
                                    .Include("~/Scripts/bootstrap.js")
                                    .Include("~/Scripts/jquery-ui-{version}.js")
                                    .Include("~/Scripts/application.js");
            bundles.Add(scriptBundle);

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            var stylesBundle = new OrderedStyleBundle("~/bundles/css")
                                        .IncludeWithRewrite("~/Content/themes/base/jquery-ui.min.css")
                                        .IncludeWithRewrite("~/Content/themes/base/all.css")                               
                                        .IncludeWithRewrite("~/Content/bootstrap.css")
                                        .IncludeWithRewrite("~/Content/site.css")
                                        .IncludeWithRewrite("~/Content/application.css");
            bundles.Add(stylesBundle);
            
            BundleTable.EnableOptimizations = true;
        }
    }
}