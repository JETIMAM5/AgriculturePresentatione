using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.Controllers
{
    public class AnnoncementController : Controller
    {
        private readonly IAnnoncementService _annoncementService;

        public AnnoncementController(IAnnoncementService annoncementService)
        {
            _annoncementService = annoncementService;
        }

        public IActionResult Index()
        {
            var values = _annoncementService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnoncement() 
        {
        return View();
        }
        [HttpPost]
        public IActionResult AddAnnoncement(Annoncement annoncement) 
        {
            annoncement.Date= DateTime.Parse(DateTime.Now.ToShortDateString());
            annoncement.Status = false;
        _annoncementService.Insert(annoncement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnoncement(int id)
        {
            var values = _annoncementService.GetByID(id);
            _annoncementService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAnnoncement(int id)
        {
            var values = _annoncementService.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAnnoncement(Annoncement annoncement)
        {
            _annoncementService.Update(annoncement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id) 
        {
        _annoncementService.AnnoncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id) 
        {
        _annoncementService.AnnoncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
