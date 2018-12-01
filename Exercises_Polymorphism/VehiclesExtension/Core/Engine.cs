using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Models;

namespace VehiclesExtension.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Vehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

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
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(value);
                        }
                        else
                        {
                            bus.Drive(value);
                        }
                    }
                    else if (action == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else
                        {
                            bus.Refuel(value);
                        }
                    }
                    else
                    {
                        bus.DriveEmptyBuss(value);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
