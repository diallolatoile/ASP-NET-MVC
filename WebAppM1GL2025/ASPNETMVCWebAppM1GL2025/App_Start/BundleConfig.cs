using System.Web;
using System.Web.Optimization;

namespace ASPNETMVCWebAppM1GL2025
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/niceadmin/css").Include(
                    "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
                    "~/Content/assets/vendor/bootstrap-icons/bootstrap-icons.css",
                    "~/Content/assets/vendor/boxicons/css/boxicons.min.css",
                    "~/Content/assets/vendor/quill/quill.snow.css",
                    "~/Content/assets/vendor/quill/quill.bubble.css",
                    "~/Content/assets/vendor/remixicon/remixicon.css",
                    "~/Content/assets/vendor/simple-datatables/style.css",
                    "~/Content/assets/css/style.css",
                    "~/Content/assets//vendor/simple-datatables/style.css"));


            bundles.Add(new Bundle("~/bundles/niceadmin/js").Include(
                    "~/Scripts/assets/vendor/apexcharts/apexcharts.min.js",
                    "~/Scripts/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/Scripts/assets/vendor/chart.js/chart.umd.js",
                    "~/Scripts/assets/vendor/echarts/echarts.min.js",
                    "~/Scripts/assets/vendor/quill/quill.js",
                    "~/Scripts/assets/vendor/simple-datatables/simple-datatables.js",
                    "~/Scripts/assets/vendor/tinymce/tinymce.min.js",
                    "~/Scripts/assets/vendor/php-email-form/validate.js",
                    "~/Scripts/assets/js/main.js"));
        }
    }
}
