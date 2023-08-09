using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;

namespace AgriculturePresentatione.ViewComponents
{
	public class _TopAddressPartial:ViewComponent
	{
		private readonly IAddresService _addressService;

		public _TopAddressPartial(IAddresService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke() 
		{
			 var values =_addressService.GetListAll();
		return View(values);
		}
	}
}
