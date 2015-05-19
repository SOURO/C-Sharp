using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models; 

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        [NonAction]
        public string GetMessage()
        {
            return "I am learning C#, beleive me it is fun";
        }
        public ActionResult GetView()
        {
            Bike bike = new Bike();
            bike.BikeName = "Pulsor";
            bike.BikeModel = "RS200";
            bike.BikePrice = 120000;
            ViewData["Bike"] = bike;
            return View("SampleView");
        }
    }
}
