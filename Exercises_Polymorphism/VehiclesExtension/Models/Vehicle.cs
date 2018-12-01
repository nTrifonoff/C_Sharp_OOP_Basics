using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Contracts;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        public bool IsVehicleEmpty { get; set; }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }

        public virtual void Drive(double distance)
        {
            double currentFuelConsumption = this.FuelConsumption;

            double neededFuel = distance * this.FuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public void DriveEmptyBuss(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"Bus needs refueling");
            }
            this.FuelQuantity -= neededFuel;
            Console.WriteLine($"Bus travelled {distance} km");
        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + fuel > this.TankCapacity )
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            if (this is Truck)
            {
                fuel *= 0.95;
            }
            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return ($"{this.GetType().Name}: {this.FuelQuantity:F2}");
        }
    }
}
