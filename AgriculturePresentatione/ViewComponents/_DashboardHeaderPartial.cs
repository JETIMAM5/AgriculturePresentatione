using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
    public class _DashboardHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
        return View();  
        }
    }
}
