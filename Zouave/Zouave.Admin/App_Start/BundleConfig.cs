using System.Web;
using System.Web.Optimization;

namespace Zouave.Admin
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                 "~/Scripts/jquery.validate.js"
                 ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(

            //             "~/Content/unicorn/js/jquery.min.js"
            //));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //       "~/Content/unicorn/js/jquery.validate.js"
            //       ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                         "~/Content/unicorn/js/jquery-ui.custom.js",
                         "~/Content/unicorn/js/jquery.icheck.min.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryplugins").Include(

                        "~/Content/unicorn/js/excanvas.min.js",
                        "~/Content/unicorn/js/fullcalendar.min.js",
                       "~/Content/unicorn/js/jquery.flot.min.js",
                        "~/Content/unicorn/js/jquery.flot.pie.min.js",
                        "~/Content/unicorn/js/jquery.flot.resize.min.js",
                        "~/Content/unicorn/js/jquery.sparkline.min.js",      /**图表*/

                         "~/Content/unicorn/js/jquery.wizard.js",            /*向导*/

                         "~/Content/unicorn/js/jquery.nicescroll.min.js",     /*其他*/

                         "~/Content/unicorn/js/jquery.gritter.min.js",
                 "~/Content/unicorn/js/jquery.dataTables.min.js",
                 "~/Content/unicorn/js/jquery.masonry.min.js",
                 "~/Content/unicorn/js/select2.min.js",
                 "~/Content/unicorn/js/bootbox.min.js",
                 "~/Content/unicorn/js/wysihtml5.js",
                 "~/Content/unicorn/js/bootstrap-wysihtml5.js"

                      ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",

                  "~/Scripts/respond.js"));


            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            //admin js
            bundles.Add(new ScriptBundle("~/bundles/unicorn").Include(
                                         "~/Content/unicorn/js/unicorn.js",
                                         "~/Content/unicorn/js/unicorn.dashboard.js",
                "~/Content/unicorn/js/unicorn.tables.js",
                //  "~/Content/unicorn/js/unicorn.calendar.js",
                //"~/Content/unicorn/js/unicorn.charts.js",
                //"~/Content/unicorn/js/unicorn.chat.js",/*这个貌似不兼容*/
                "~/Content/unicorn/js/unicorn.form_validation.js",
                "~/Content/unicorn/js/unicorn.wizard.js",
                "~/Content/unicorn/js/unicorn.jui.js"
                  ));

            bundles.Add(new StyleBundle("~/Content/admin").Include(
                   "~/Content/unicorn/css/jquery-ui.css",
                 "~/Content/unicorn/css/bootstrap.min.css",
                 "~/Content/unicorn/css/font-awesome.css",
                 "~/Content/unicorn/css/unicorn.css",
                 "~/Content/unicorn/css/fullcalendar.css",
                 "~/Content/unicorn/css/jquery.jscrollpane.css",
                 "~/Content/unicorn/css/colorpicker.css",
                 "~/Content/unicorn/css/datepicker.css",
                 "~/Content/unicorn/css/icheck/flat/blue.css",
                 "~/Content/unicorn/css/select2.css",
                 "~/Content/unicorn/css/jquery.gritter.css"
                 ));

            // 将 EnableOptimizations 设为 false 以进行调试。有关详细信息，
            // 请访问 http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
