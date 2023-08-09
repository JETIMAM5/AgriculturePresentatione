using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
	public class _AnnoncementPartial : ViewComponent
	{
		private readonly IAnnoncementService _annoncementService;

		public _AnnoncementPartial(IAnnoncementService annoncementService)
		{
			_annoncementService = annoncementService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _annoncementService.GetListAll();
			return View(values);
		}
	}
}
