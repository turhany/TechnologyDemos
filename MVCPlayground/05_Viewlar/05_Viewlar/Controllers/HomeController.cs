using System.Web.Mvc;

namespace _05_Viewlar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Ana sayfa
        public ActionResult homepage()
        {
            return View();
        }

        //Hakkımızda
        public ActionResult about()
        {
            return View();
        }

        //İletişi
        public ActionResult contact()
        {
            return View();
        }
    }
}