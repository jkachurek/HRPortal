using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HRPortal.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/scripts/modernizr-2.6.2.js"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/scripts/jquery-1.10.2.min.js",
                "~/scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/uiscripts").Include(
                "~/scripts/jquery-ui-1.11.4.min.js",
                "~/Content/themes/base/all.css"));

            bundles.Add(new StyleBundle("~/bundles/uistyles").Include(
                "~/Content/themes/base/all.css"));
        }
    }
}