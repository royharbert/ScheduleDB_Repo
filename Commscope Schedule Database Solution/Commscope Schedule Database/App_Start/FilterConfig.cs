using System.Web;
using System.Web.Mvc;

namespace Commscope_Schedule_Database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
