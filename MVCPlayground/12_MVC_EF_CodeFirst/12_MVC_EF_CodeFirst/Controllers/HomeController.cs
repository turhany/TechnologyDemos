using System.Linq;
using System.Web.Mvc;
using _12_MVC_EF_CodeFirst.Models.Managers;
using _12_MVC_EF_CodeFirst.ViewModels.Home;

namespace _12_MVC_EF_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            var db = new DatabaseContext();

            HomePageViewModel model = new HomePageViewModel();
            model.Kisiler = db.Kisiler.ToList();
            model.Adresler = db.Adresler.ToList();

            return View(model);

            //List<Kisiler> kisiler = db.Kisiler.ToList();
            //return View(kisiler);
        }
    }
}