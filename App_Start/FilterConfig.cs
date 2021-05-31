using System.Web;
using System.Web.Mvc;

namespace DiazPierri_Ezequiel_LPPA_Parcial1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
