using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.ViewModels; 

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

            BikeViewModel vmBike = new BikeViewModel();
            vmBike.BikeNameAndModel = bike.BikeName + " " + bike.BikeModel;
            vmBike.BikePrice = bike.BikePrice.ToString("G");
            if (bike.BikePrice > 200000)
            {
                vmBike.BikeColor = "green";
            }
            else
            {
                vmBike.BikeColor = "red";
            }
            return View("SampleView",vmBike);
        }
    }
}
