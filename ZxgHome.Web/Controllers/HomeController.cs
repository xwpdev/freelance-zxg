using System.Web.Mvc;

namespace ZxgHome.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Web
        public ActionResult Web()
        {
            return View();
        }

        // GET: Home/Game
        public ActionResult Game()
        {
            return View();
        }

        // GET: Home/Vr
        public ActionResult Vr()
        {
            return View();
        }

        // GET: Home/Graphics
        public ActionResult Graphics()
        {
            return View();
        }

        // POST: Home/PostEmail
        [HttpPost]
        public ActionResult PostEmail(string name, string email, string message)
        {
            // ViewBag.EmailSuccess = true;
            return View("Index");
        }
    }
}