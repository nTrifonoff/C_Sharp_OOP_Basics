﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Feline
{
    public abstract class Feline : Mammal
    {
        private string breed;

        public Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
