using System.Web;
using System.Web.Mvc;

namespace DBU_Advising_Scheduler
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
