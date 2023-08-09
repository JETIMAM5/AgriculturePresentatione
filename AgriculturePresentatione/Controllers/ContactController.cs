using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = _contactService.GetByID(id);
            _contactService.Delete(values);
            return  RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult MessageDetails(int id) 
        {
        var value = _contactService.GetByID(id);
            return View(value);
        }
    }
}
