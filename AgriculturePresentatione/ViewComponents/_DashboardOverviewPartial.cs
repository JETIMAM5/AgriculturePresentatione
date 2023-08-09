using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentatione.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.receivedMessageCountThisMonth = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();
            
            ViewBag.AnnouncementTrue = c.Annoncements.Where(x=>x.Status==true).Count();
            ViewBag.AnnouncementFalse = c.Annoncements.Where(x=>x.Status==false).Count();

            ViewBag.tahilAmbariSorumlusu= c.Teams.Where(x=>x.Title =="Tahıl Ambarı Sorumlusu").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.yiyecekDepoAmiri= c.Teams.Where(x=>x.Title =="Yiyecek Depo Amiri").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.ciftlikBakimcisi= c.Teams.Where(x=>x.Title =="Çiftlik Bakımcısı").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.hayvanakimcisi= c.Teams.Where(x=>x.Title =="Hayvan Bakımcısı").Select(y=>y.PersonName).FirstOrDefault();

            
            return View();

            
        }
    }
}
