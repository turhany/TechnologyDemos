using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult homepage(string text1, bool check1, string list1) //ui control id leri
        {
            var t1 = Request.Form["text1"];
            var c1 = Request.Form.GetValues("check1")[0]; //checkbox için bu şekilde alınır
            var l1 = Request.Form["list1"];

            //param ve request.form ile viewden data alınır

            return View();
        }
    }
}