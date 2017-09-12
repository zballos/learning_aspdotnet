using System.Web;
using System.Web.Mvc;

namespace EZ.MvcDotNet.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
