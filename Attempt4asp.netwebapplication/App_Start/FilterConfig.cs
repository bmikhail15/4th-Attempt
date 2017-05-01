using System.Web;
using System.Web.Mvc;

namespace Attempt4asp.netwebapplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
