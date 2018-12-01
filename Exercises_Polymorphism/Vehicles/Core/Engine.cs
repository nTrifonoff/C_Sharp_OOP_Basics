using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                string action = command[0];
                string vehicleType = command[1];
                double value = double.Parse(command[2]);

                try
                {
                    if (action == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Drive(value);
                        }
                        else
                        {
                            truck.Drive(value);
                        }
                    }
                    else
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else
                        {
                            truck.Refuel(value);
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }              
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
