using _09_ModelsModelBinding.Models;
using _09_ModelsModelBinding.ViewModels;
using System.Web.Mvc;

namespace _09_ModelsModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Türhan";
            kisi.Soyad = "Yıldırım";
            kisi.Yas = 25;

            //return View(kisi);

            Adres adres = new Adres();
            adres.AdresTanim = "deneme adres tanımı";
            adres.Sehir = "Istanbul";

            homepageViewModel mod = new homepageViewModel();
            mod.KisiNesnesi = kisi;
            mod.AdresNesnesi = adres;

            return View(mod);
        }

        [HttpPost]
        public ActionResult homepage(homepageViewModel k)
        {
            return View(k);
        }
    }
}