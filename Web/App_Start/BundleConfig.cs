using System.Web;
using System.Web.Optimization;

//Johan piza 9/11/2019 

/**
 * 
 */
namespace Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/creative").Include(
                        "~/Scripts/creative.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-easing").Include(
                        "~/Scripts/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-magnific").Include(
                        "~/Scripts/jquery.magnific-popup.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));






            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/creative.css", "~/Content/creative.min.css",
                      "~/Content/formulario.css", "~/Content/magnific-popup.css", "~/Content/Site.css"));
        }
    }
}
