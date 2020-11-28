using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            //ViewData["text1"] = "Türhan Yıldırım";
            //ViewData["check1"] = true;

            //ViewBag.text1 = "Türhan Yıldırım";
            //ViewBag.check1 = true;

            TempData["text1"] = "Türhan Yıldırım";
            TempData["check1"] = true;

            //tempdata ile tutulan data, başka sayfalarda da erişilebilir halde data tutuyor, sadece bir action öteye kadar saklar
            //viewdata, viewbag diğer aciton da saklanmıyor

            return View();
        }

        public ActionResult about()
        {
            ViewBag.text1 = "Türhan Yıldırım";
            ViewBag.check1 = true;
            ViewBag.list1 = new List<SelectListItem>()
            {
                new SelectListItem { Text = "test1", Value = "test1" },
                new SelectListItem { Text = "test2", Value = "test2" }
            };

            //Diğer sayfaya data taşıdık
            TempData["t1"] = ViewBag.text1;
            TempData["c1"] = ViewBag.check1;


            return View();
        }

        public ActionResult contact()
        {
            ViewBag.text1 = TempData["t1"];
            ViewBag.check1 = TempData["c1"];

            return View();
        }

        public ActionResult blog()
        {
            ViewBag.text1 = TempData["t1"];
            ViewBag.check1 = TempData["c1"];

            return View();
        }
    }
}