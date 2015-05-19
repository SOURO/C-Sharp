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

            BikeListViewModel bikeListViewModel = new BikeListViewModel();
            BikeBusinessLayer bikeList = new BikeBusinessLayer();
            List<Bike> bikes = bikeList.GetBikes();
            List<BikeViewModel> bikeViewModels = new List<BikeViewModel>();
            foreach (Bike bike in bikes)
            {
                BikeViewModel bikeViewModel = new BikeViewModel();
                bikeViewModel.BikeNameAndModel = bike.BikeName + " " + bike.BikeModel;
                bikeViewModel.BikePrice = bike.BikePrice.ToString("G");
                if (bike.BikePrice > 200000)
                {
                    bikeViewModel.BikeColor = "green";
                }
                else
                {
                    bikeViewModel.BikeColor = "red";
                }
                bikeViewModels.Add(bikeViewModel);
            }
            bikeListViewModel.Bikes = bikeViewModels;
            return View("SampleView", bikeListViewModel);
        }
    }
}
