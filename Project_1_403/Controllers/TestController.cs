using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_403.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string display)
        {
            if (display == "true")
            {
                ViewBag.hide = "normal";
            }
            else if (display == "false")
            {
                ViewBag.hide = "none";
            }
            return View();
        }
    }
}