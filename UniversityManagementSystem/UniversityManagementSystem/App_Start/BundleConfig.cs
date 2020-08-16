using System.Web;
using System.Web.Optimization;

namespace UniversityManagementSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.5.1.min.js",
                        "~/plugins/jQueryUI/jquery-ui.min.js"
                        ));  //order 1

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.min.js",
                     "~/Scripts/raphael-min.js",
                     "~/Scripts/respond.js",
                     "~/plugins/datatables/jquery.dataTables.min.js",
                     "~/plugins/datatables/dataTables.bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/others").Include(
                    "~/plugins/sparkline/jquery.sparkline.min.js",
                    "~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                    "~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                    "~/plugins/knob/jquery.knob.js",
                    "~/plugins/select2/select2.full.min.js",
                    "~/plugins/input-mask/jquery.inputmask.js",
                    "~/plugins/input-mask/jquery.inputmask.date.extensions.js",
                    "~/plugins/input-mask/jquery.inputmask.extensions.js",
                    "~/Scripts/jquery.confirm.min.js",
                    "~/Scripts/moment.min.js",
                    "~/plugins/daterangepicker/daterangepicker.js",
                    "~/plugins/colorpicker/bootstrap-colorpicker.min.js",
                    "~/plugins/timepicker/bootstrap-timepicker.min.js",
                    "~/plugins/iCheck/icheck.min.js",
                    "~/plugins/datepicker/bootstrap-datepicker.js",
                    "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                    "~/plugins/slimScroll/jquery.slimscroll.min.js",
                    "~/plugins/fastclick/fastclick.min.js",
                    "~/plugins/toastr/toastr.js",
                    "~/dist/js/app.min.js",
                    "~/dist/js/demo.js",
                    "~/plugins/ladda/ladda.min.js",
                    "~/Scripts/mustache.js",
                    "~/plugins/ladda/spin.js",
                    "~/plugins/newsticker/ticker.js",
                    "~/plugins/marquee/js/marquee.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                    "~/Jquery/Common/site.layout.js",
                    "~/Jquery/Common/site.common.js",
                    "~/Jquery/Common/site.all.combo.js",
                     "~/Jquery/Common/otherCommon.js",
                     "~/Jquery/Validation/iValidation.js"
                    ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/plugins/font-awesome/css/font-awesome.min.css",
                      "~/plugins/ionicons/css/ionicons.min.css",
                      "~/plugins/datatables/dataTables.bootstrap.css",
                      "~/dist/css/AdminLTE.min.css",
                      "~/dist/css/skins/_all-skins.min.css",
                      "~/plugins/iCheck/flat/blue.css",
                      "~/plugins/morris/morris.css",
                      "~/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                      "~/plugins/datepicker/datepicker3.css",
                      "~/plugins/daterangepicker/daterangepicker-bs3.css",
                      "~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/plugins/toastr/toastr.css",
                      "~/plugins/newsticker/ticker.css",
                      "~/plugins/marquee/css/marquee.css",
                      "~/plugins/marquee/css/example.css",
                      "~/Content/site.css"));
        }
    }
}
