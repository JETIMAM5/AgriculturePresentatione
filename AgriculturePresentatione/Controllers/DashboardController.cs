using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
