using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11_HelperMethods.Models;

namespace _11_HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message() { Level = 1, Text = "Lorem  falan filan" });
            messages.Add(new Message() { Level = 2, Text = "Lorem Ipsum  filan" });
            messages.Add(new Message() { Level = 3, Text = "Lorem Ipsum falan " });
            messages.Add(new Message() { Level = 4, Text = "Ipsum falan filan" });


            return View(messages);
        }
    }
}