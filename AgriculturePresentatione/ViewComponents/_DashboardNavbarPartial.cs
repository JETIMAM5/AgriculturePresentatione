using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
    public class _DashboardNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
