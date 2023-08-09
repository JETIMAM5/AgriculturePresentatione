using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
	public class _AddressPartial:ViewComponent
	{
		private readonly IAddresService _addresService;

        public _AddressPartial(IAddresService addresService)
        {
            _addresService = addresService;
        }

        public IViewComponentResult Invoke() 
		{
			var values=_addresService.GetListAll();
		return View(values);
		}
	}
}
