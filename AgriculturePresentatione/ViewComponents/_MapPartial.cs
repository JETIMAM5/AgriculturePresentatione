using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
    public class _MapPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            AgricultureContext agricultureContext = new AgricultureContext();
            var values = agricultureContext.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
