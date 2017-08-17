using System.Web.Mvc;

namespace ZxgHome.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // ViewBag.EmailSuccess = false;
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