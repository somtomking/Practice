using System.Web;
using System.Web.Optimization;

namespace Zouave.Admin
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //admin js
            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                                        "~/Scripts/unicorn/excanvas.min.js",
                                        "~/Scripts/unicorn/jquery.min.js",
                                        "~/Scripts/unicorn/jquery-ui.custom.js",
                                        "~/Scripts/unicorn/jquery.sparkline.min.js",
                                        "~/Scripts/unicorn/jquery.nicescroll.min.js",
                                        "~/Scripts/unicorn/jquery.flot.min.js",
                                        "~/Scripts/unicorn/jquery.flot.pie.min.js",
                                        "~/Scripts/unicorn/jquery.flot.resize.min.js",
                                        "~/Scripts/unicorn/jquery.icheck.min.js",
                                        "~/Scripts/unicorn/jquery.wizard.js",
                                        "~/Scripts/unicorn/jquery.validate.js",
                                        "~/Scripts/unicorn/jquery.gritter.min.js",
                                        "~/Scripts/unicorn/jquery.dataTables.min.js",
                                        "~/Scripts/unicorn/jquery.masonry.min.js",
                                        "~/Scripts/unicorn/jquery.sparkline.min.js",
                                        "~/Scripts/unicorn/bootstrap.min.js",
                                        "~/Scripts/unicorn/fullcalendar.min.js",
                                        "~/Scripts/jquery.nicescroll.min.js",
                                        "~/Scripts/unicorn/select2.min.js",
                                        "~/Scripts/unicorn/bootbox.min.js",
                                        "~/Scripts/unicorn/wysihtml5.js",
                                        "~/Scripts/unicorn/bootstrap-wysihtml5.js",
                                        "~/Scripts/unicorn/unicorn.js",
                                        "~/Scripts/unicorn/unicorn.dashboard.js",
                                        "~/Scripts/unicorn/unicorn.tables.js",
                                        "~/Scripts/unicorn/unicorn.calendar.js",
                                        "~/Scripts/unicorn/unicorn.charts.js",
                                        "~/Scripts/unicorn/unicorn.chat.js",
                                        "~/Scripts/unicorn/unicorn.form_validation.js",
                                        "~/Scripts/unicorn/unicorn.wizard.js",
                                        "~/Scripts/unicorn/unicorn.jui.js"
                  ));

            bundles.Add(new StyleBundle("~/Content/admin").Include(
                 "~/Content/unicorn/css/bootstrap.min.css",
                 "~/Content/unicorn/css/font-awesome.css",
                 "~/Content/unicorn/css/unicorn.css",
                 "~/Content/unicorn/css/fullcalendar.css",
                 "~/Content/unicorn/css/jquery.jscrollpane.css",
                 "~/Content/unicorn/css/colorpicker.css",
                 "~/Content/unicorn/css/datepicker.css",
                 "~/Content/unicorn/css/icheck/flat/blue.css",
                 "~/Content/unicorn/css/select2.css",
                 "~/Content/unicorn/css/jquery-ui.css",
                 "~/Content/unicorn/css/jquery.gritter.css"
                 ));

            // 将 EnableOptimizations 设为 false 以进行调试。有关详细信息，
            // 请访问 http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
