using System.Web;
using System.Web.Mvc;
using ViewEngines.Controllers;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Register global filter
            filters.Add(new RemoveXHeader());
            filters.Add(new AddMyCustomBakeryHeader());

            filters.Add(new HandleErrorAttribute());
        }
    }
}
