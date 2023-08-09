using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
		return View();	
		}
	}
}
