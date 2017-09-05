using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZxgHome.Web.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pages/View/{name}
        [Route("Pages/View/{name}")]
        public new ActionResult View(string name)
        {
            return View();
        }
    }
}