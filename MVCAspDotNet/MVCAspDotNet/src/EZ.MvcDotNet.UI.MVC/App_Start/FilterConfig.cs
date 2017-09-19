using System.Web;
using System.Web.Mvc;
using EZ.MvcDotNet.Infra.CrossCutting.MvcFilters;

namespace EZ.MvcDotNet.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
