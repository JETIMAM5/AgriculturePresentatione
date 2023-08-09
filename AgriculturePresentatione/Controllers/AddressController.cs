using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddresService _addresService;

        public AddressController(IAddresService addresService)
        {
            _addresService = addresService;
        }

        public IActionResult Index()
        {
            var values = _addresService.GetListAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            var value = _addresService.GetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditAddress(Address address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(address);
            if (result.IsValid)
            {
                _addresService.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                _addresService.Update(address);
                return RedirectToAction("Index");

            }
        }
    }
}
