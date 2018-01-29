using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Automated_Teller_Machine.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //GET /home/index
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having Trouble? Send us a message. ";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: send message to HQ
            ViewBag.TheMessage = "Thank you. We received your message. ";

            return View();
        }

        public  ActionResult Serial(string letterCase)
        {
            var serial = "ASPNET5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
    }
}