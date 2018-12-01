using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds.Factories
{
    class BirdFactory
    {
        public Bird CreateBird(string type, string name, double weight, double wingSize)
        {
            type = type.ToLower();

            switch (type)
            {
                case "owl":
                    return new Owl(name, weight, wingSize);
                case "hen":
                    return new Hen(name, weight, wingSize);
                default:
                    throw new ArgumentException("Invalid bird type!");
            }
        }
    }
}
