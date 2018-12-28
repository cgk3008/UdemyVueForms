using System.Web;
using System.Web.Mvc;

namespace Udemy_VueJS_Forms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
