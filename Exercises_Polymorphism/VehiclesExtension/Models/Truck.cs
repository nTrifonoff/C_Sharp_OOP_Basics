﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double airConditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += airConditionConsumption;
        }
    }
}
