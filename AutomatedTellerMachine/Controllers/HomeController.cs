using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        // /Home/Index
        [MyLogginFilter]
        public ActionResult Index()
        {
            return View();
        }
        // /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a Message!";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: send message to HQ
            ViewBag.TheMessage = "Thanks we got your message!";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string lettercase)
        {
            var serial = "ASPNETMVCATM1";
            if (lettercase == "lower")
            {
                return Content(serial.ToLower());
            }
            // return Content(serial);
            return Json(new { name = "serial", value = serial}, JsonRequestBehavior.AllowGet);
            // return RedirectToRoute("Home/Index");
        }
    }
}