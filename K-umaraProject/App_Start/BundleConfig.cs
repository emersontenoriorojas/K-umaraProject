using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace K_umaraProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/css/bootstrap/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/owl.carousel.css",
                "~/Content/css/owl.theme.css",
                "~/Content/css/owl.transitions.css",
                "~/Content/css/meanmenu/meanmenu.min.css",
                "~/Content/css/animate.css",
                "~/Content/css/normalize.css",
                "~/Content/css/scrollbar/jquery.mCustomScrollbar.min.css",
                "~/Content/css/jvectormap/jquery-jvectormap-2.0.3.css",
                "~/Content/css/notika-custom-icon.css",
                "~/Content/css/wave/waves.min.css",
                "~/Content/css/main.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css"));


                    bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Content/js/vendor/modernizr-2.8.3.min.js",
                "~/Content/js/vendor/jquery-1.12.4.min.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/wow.min.js",
                "~/Content/js/jquery-price-slider.js",
                "~/Content/js/owl.carousel.min.js",
                "~/Content/js/jquery.scrollUp.min.js",
                "~/Content/js/meanmenu/jquery.meanmenu.js",
                "~/Content/js/counterup/jquery.counterup.min.js",
                "~/Content/js/counterup/waypoints.min.js",
                "~/Content/js/counterup/counterup-active.js",
                "~/Content/js/scrollbar/jquery.mCustomScrollbar.concat.min.js",
                "~/Content/js/jvectormap/jquery-jvectormap-2.0.2.min.js",
                "~/Content/js/jvectormap/jquery-jvectormap-world-mill-en.js",
                "~/Content/js/jvectormap/jvectormap-active.js",
                "~/Content/js/sparkline/jquery.sparkline.min.js",
                "~/Content/js/sparkline/sparkline-active.js",
                "~/Content/js/flot/jquery.flot.js",
                "~/Content/js/flot/jquery.flot.resize.js",
                "~/Content/js/flot/curvedLines.js",
                "~/Content/js/flot/flot-active.js",
                "~/Content/js/knob/jquery.knob.js",
                "~/Content/js/knob/jquery.appear.js",
                "~/Content/js/knob/knob-active.js",
                "~/Content/js/wave/waves.min.js",
                "~/Content/js/wave/wave-active.js",
                "~/Content/js/todo/jquery.todo.js",
                "~/Content/js/plugins.js",
                "~/Content/js/main.js"));
        }
    }
}