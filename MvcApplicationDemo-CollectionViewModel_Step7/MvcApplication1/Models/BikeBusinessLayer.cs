using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class BikeBusinessLayer
    {
        public List<Bike> GetBikes()
        {
            List<Bike> bikes = new List<Bike>();
            Bike bike = new Bike();
            bike.BikeName = "Pulsor";
            bike.BikeModel = "RS200";
            bike.BikePrice = 120000;
            bikes.Add(bike);

            bike = new Bike();
            bike.BikeName = "Yamaha";
            bike.BikeModel = "FZ-16";
            bike.BikePrice = 75000;
            bikes.Add(bike);

            bike = new Bike();
            bike.BikeName = "KTM";
            bike.BikeModel = "690 Duke";
            bike.BikePrice = 400000;
            bikes.Add(bike);

            bike = new Bike();
            bike.BikeName = "Kawasaki";
            bike.BikeModel = "Ninja";
            bike.BikePrice = 150000;
            bikes.Add(bike);

            bike = new Bike();
            bike.BikeName = "Ducati";
            bike.BikeModel = "RS200";
            bike.BikePrice = 300000;
            bikes.Add(bike);

            bike = new Bike();
            bike.BikeName = "Agusta";
            bike.BikeModel = "Brutale";
            bike.BikePrice = 180000;
            bikes.Add(bike);

            return bikes;
        }
    }
}