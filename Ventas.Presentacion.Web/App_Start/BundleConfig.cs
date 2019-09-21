using System.Web;
using System.Web.Optimization;

namespace Ventas.Presentacion.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/Galerias/Vue.js",
                        "~/Scripts/Galerias/axios.js",
                        "~/Scripts/Galerias/download.js",              
                        "~/Scripts/Galerias/bootstrap4-vue.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Galerias/Bootstrap4.css",
                      "~/Content/Galerias/bootstrap4-vue.css",                      
                      "~/Content/site.css"));
        }
    }
}
