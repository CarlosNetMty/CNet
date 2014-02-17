using System.Web;
using System.Web.Optimization;

namespace CNet.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/scripts/framework/jquery-2.1.0.js", "~/scripts/framework/jquery-ui-1.10.4.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/scripts/jquery.unobtrusive*",
                        "~/scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/scripts/framework/modernizr-2.7.1"));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/content/site.css",
                "~/content/jquery-ui-1.10.4.css"));

            //bundles.Add(new StyleBundle("~/content/themes/base/css").Include(
            //            "~/content/themes/base/jquery.ui.core.css",
            //            "~/content/themes/base/jquery.ui.resizable.css",
            //            "~/content/themes/base/jquery.ui.selectable.css",
            //            "~/content/themes/base/jquery.ui.accordion.css",
            //            "~/content/themes/base/jquery.ui.autocomplete.css",
            //            "~/content/themes/base/jquery.ui.button.css",
            //            "~/content/themes/base/jquery.ui.dialog.css",
            //            "~/content/themes/base/jquery.ui.slider.css",
            //            "~/content/themes/base/jquery.ui.tabs.css",
            //            "~/content/themes/base/jquery.ui.datepicker.css",
            //            "~/content/themes/base/jquery.ui.progressbar.css",
            //            "~/content/themes/base/jquery.ui.theme.css"));

        }
    }
}