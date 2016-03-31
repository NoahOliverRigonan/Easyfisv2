﻿using System.Web;
using System.Web.Optimization;

namespace easyfis
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Homepage 
            // ====================================
            // Library Cascading Style Sheets - CSS
            // ====================================
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/bootstrap.min.css",
            //          "~/Content/toastr.css"));

            //// ====================================================
            //// Library Cascading Style Sheets for Fontawesome - CSS
            //// ====================================================
            //bundles.Add(new StyleBundle("~/Font-Awesome/css").Include(
            //          "~/Content/font-awesome/css/font-awesome.css",
            //          "~/Content/font-awesome/css/font-awesome.min.css"));

            // ===================================
            // Custom Cascading Style Sheets - CSS
            // ===================================
            bundles.Add(new StyleBundle("~/Content/custom-css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/toastr.css",
                      "~/Content/style.css",
                      "~/fonts/font-awesome/css/font-awesome.css",
                      "~/fonts/font-awesome/css/font-awesome.min.css"));

            // ========================
            // Library Javascripts - JS
            // ========================
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                //"~/Scripts/jquery.min.js",
                      "~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/collapse.js",
                      "~/Scripts/tooltip.js",
                      "~/Scripts/custom-tooltip.js",
                      "~/Scripts/dropdown.js",
                      "~/Scripts/transition.js",
                      "~/Scripts/scrollspy.js",
                      "~/Scripts/modal.js",
                      "~/Scripts/alert.js",
                      "~/Scripts/tab.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/toastr.js"
                      ));

            //// =======================
            //// Custom JavaScripts - JS
            //// =======================
            //bundles.Add(new ScriptBundle("~/Scripts/custom-js").Include(
            //        "~/Scripts/bootstrap.js",
            //        "~/Scripts/bootstrap.min.js",
            //        //"~/Scripts/jquery.min.js",
            //        "~/Scripts/jquery-1.10.2.js",
            //        "~/Scripts/jquery-1.10.2.min.js",
            //        "~/Scripts/collapse.js",
            //        "~/Scripts/tooltip.js",
            //        "~/Scripts/custom-tooltip.js",
            //        "~/Scripts/dropdown.js",
            //        "~/Scripts/transition.js",
            //        "~/Scripts/scrollspy.js",
            //        "~/Scripts/modal.js",
            //        "~/Scripts/alert.js",
            //        "~/Scripts/tab.js",
            //        "~/Scripts/respond.js",
            //        "~/Scripts/toastr.js",
            //        "~/Scripts/style.js"));


            // Software Dashboard Page Over here ...
            // ==============================================
            // Custom Cascading Style Sheets - CSS (Software)
            // ==============================================
            bundles.Add(new StyleBundle("~/Content/Software-css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/toastr.css",
                      "~/Content/software.css",
                      "~/fonts/font-awesome/css/font-awesome.css",
                      "~/fonts/font-awesome/css/font-awesome.min.css"));

            // ==================================
            // Custom JavaScripts - JS (Software)
            // ==================================
            bundles.Add(new ScriptBundle("~/Scripts/Software-js").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/bootstrap.min.js",
                     //"~/Scripts/jquery.min.js",
                     "~/Scripts/jquery-1.10.2.js",
                     "~/Scripts/jquery-1.10.2.min.js",
                     "~/Scripts/transition.js",
                     "~/Scripts/collapse.js",
                     "~/Scripts/dropdown.js",
                     "~/Scripts/modal.js",
                     "~/Scripts/tab.js",
                     "~/Scripts/sidebar-menu.js",
                     "~/Scripts/push-left-menu.js",
                     "~/Scripts/toastr.js",
                    "~/Scripts/style.js"));

            // =============
            // WIJMO Scripts
            // =============
            bundles.Add(new ScriptBundle("~/WijmoScripts/Wijmo-js").Include(
                     "~/wijmo/controls/wijmo.min.js",
                     "~/wijmo/controls/wijmo.input.min.js",
                     "~/wijmo/controls/wijmo.grid.min.js",
                     "~/wijmo/controls/wijmo.chart.min.js"
                     ));

            // ==================
            // WIJMO Style Sheets
            // ==================
            bundles.Add(new StyleBundle("~/WijmoCSS/Wijmo-css").Include(
                      "~/wijmo/styles/wijmo.min.css"
                      ));

            // ========
            // JQueries
            // ========
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // =================
            // JQuery Validation
            // =================
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
        }
    }
}
