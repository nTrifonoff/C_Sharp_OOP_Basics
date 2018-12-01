using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>(carsCount);

            for (int i = 0; i < carsCount; i++)
            {
                //< Model > < EngineSpeed > < EnginePower > < CargoWeight > < CargoType > < Tire1Pressure > < Tire1Age > 
                //< Tire2Pressure > < Tire2Age > < Tire3Pressure > < Tire3Age > < Tire4Pressure > < Tire4Age >

                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>(); 

                for (int j = 0; j < 8; j+= 2)
                {
                    double tirePressure = double.Parse(carInfo[5] + j);
                    int tireAge = int.Parse(carInfo[6] + j);

                    Tire tire = new Tire(tirePressure, tireAge);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> carsToPrint = new List<Car>();

            if (command == "fragile")
            {
                carsToPrint = cars.Where(x => x.Cargo.CargoType == "fragile")
                                  .Where(y => y.Tires.Any(k => k.TirePressure < 1)).ToList();
            }
            else
            {
                carsToPrint = cars.Where(x => x.Cargo.CargoType == "flamable")
                                  .Where(y => y.Engine.EnginePower > 250).ToList();
            }

            foreach (Car car in carsToPrint)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
