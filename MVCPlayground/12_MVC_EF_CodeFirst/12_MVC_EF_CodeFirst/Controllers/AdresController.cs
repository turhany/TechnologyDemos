using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using _12_MVC_EF_CodeFirst.Models.Managers;
using _12_MVC_EF_CodeFirst.Models;

namespace _12_MVC_EF_CodeFirst.Controllers
{
    public class AdresController : Controller
    {
        // GET: Adres
        public ActionResult Yeni()
        {
            DatabaseContext db = new DatabaseContext();
            List<Kisiler> kisiler = db.Kisiler.ToList();

            List<SelectListItem> kisilerList = kisiler.Select(p => new SelectListItem { Text = p.Ad + " " + p.Soyad, Value = p.ID.ToString() }).ToList();

            TempData["kisiler"] = kisilerList;
            ViewBag.kisiler = kisilerList;

            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Adresler adres)
        {
            DatabaseContext db = new DatabaseContext();
            Kisiler kisi = db.Kisiler.Where(p => p.ID == adres.Kisi.ID).FirstOrDefault();

            if (kisi != null)
            {
                adres.Kisi = kisi;
                db.Adresler.Add(adres);
                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    ViewBag.Result = "Kişi kaydedilmiştir.";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Kişi kaydedilememiştir.";
                    ViewBag.Status = "danger";
                }
            }
            else
            {
                ViewBag.Result = "Kişi bilgisi bulunamadı.";
                ViewBag.Status = "danger";
            }

            ViewBag.kisiler = TempData["kisiler"];

            return View();
        }

        public ActionResult Duzenle(int? adresid)
        {
            Adresler adres = null;
            if (adresid != null)
            {
                DatabaseContext db = new DatabaseContext();
                List<Kisiler> kisiler = db.Kisiler.ToList();

                List<SelectListItem> kisilerList = kisiler.Select(p => new SelectListItem { Text = p.Ad + " " + p.Soyad, Value = p.ID.ToString() }).ToList();

                TempData["kisiler"] = kisilerList;
                ViewBag.kisiler = kisilerList;

                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();
            }



            return View(adres);
        }

        [HttpPost]
        public ActionResult Duzenle(Adresler model, int? adresid)
        {
            DatabaseContext db = new DatabaseContext();
            Kisiler kisi = db.Kisiler.Where(p => p.ID == model.Kisi.ID).FirstOrDefault();
            Adresler adres = db.Adresler.Where(p => p.ID == adresid).FirstOrDefault();

            if (kisi != null)
            {
                adres.Kisi = kisi;
                adres.AdresTanimi = model.AdresTanimi;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    ViewBag.Result = "Adres güncellenmiştir.";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Adres güncellenememiştir.";
                    ViewBag.Status = "danger";
                }
            }
            else
            {
                ViewBag.Result = "Adres bilgisi bulunamadı.";
                ViewBag.Status = "danger";
            }

            ViewBag.kisiler = TempData["kisiler"];

            return View();
        }

        public ActionResult Sil(int? adresid)
        {
            Adresler adres = null;
            if (adresid != null)
            {
                DatabaseContext db = new DatabaseContext();
                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();
            }

            return View(adres);
        }

        [HttpPost, ActionName("Sil")]
        public ActionResult SilOk(int? adresid)
        {
            Adresler adres = null;
            if (adresid != null)
            {
                DatabaseContext db = new DatabaseContext();
                adres = db.Adresler.Where(x => x.ID == adresid).FirstOrDefault();

                db.Adresler.Remove(adres);
                db.SaveChanges();
            }

            return RedirectToAction("homepage", "Home");
        }
    }
}