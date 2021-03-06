﻿using System.Web;
using System.Web.Optimization;

namespace SpecjalnyTyper
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery-ui-timepicker-addon.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/themes/base/jquery-ui.css",
                      "~/Content/jquery-ui-timepicker-addon.min.css",
                      "~/Content/themes/icheck-bootstrap.css"));
            // Boorstrap dropdown select
            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select").Include(
                                  "~/Scripts/bootstrap-select.js",
                                  "~/Scripts/bootstrap-select.min.js",
                                  "~/Scripts/script-bootstrap-select.js"));

            // Bootstrap dropdown select
            bundles.Add(new StyleBundle("~/Content/Bootstrap-Select/css").Include(
                                 "~/Content/bootstrap-select.css",
                                 "~/Content/bootstrap-select.min.css"));
        }
    }
}


