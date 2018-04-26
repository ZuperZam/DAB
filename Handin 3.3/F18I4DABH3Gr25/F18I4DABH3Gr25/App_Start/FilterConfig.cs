using System.Web;
using System.Web.Mvc;

namespace F18I4DABH3Gr25
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
