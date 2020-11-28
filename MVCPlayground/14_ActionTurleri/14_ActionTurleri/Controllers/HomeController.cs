using System.Web.Mvc;
using _14_ActionTurleri.Models;

namespace _14_ActionTurleri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        #region Redirect Result Sample

        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult Index2()
        {
            //return RedirectToAction("Index");
            return Redirect("/Home/Index");
        }

        #endregion

        #region Json Result Sample
        public ActionResult Index3()
        {
            return View();
        }

        public JsonResult Index4()
        {
            Urun urn = new Urun();
            urn.ID = 5;
            urn.Adi = "Domates";
            urn.Fiyat = 12000;
            urn.Aciklama = "Bu bir deneme ürünüdür";

            return Json(urn, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index4(int? deger)
        {
            return Json(null);
        } 
        #endregion
    }
}
