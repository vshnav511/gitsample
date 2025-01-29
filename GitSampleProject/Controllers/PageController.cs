using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitSampleProject.Controllers
{
    public class PageController : Controller
    {
        // I've changed the name
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }
    }
}