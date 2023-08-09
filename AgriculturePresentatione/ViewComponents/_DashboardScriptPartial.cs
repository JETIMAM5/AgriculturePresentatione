using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
    public class _DashboardScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
        return View();  
        }
    }
}
