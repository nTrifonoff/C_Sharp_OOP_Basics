using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Animals.Birds.Factories;
using WildFarm.Animals.Mammals.Factories;
using WildFarm.Animals.Mammals.Feline.Factories;
using WildFarm.Foods.Factories;

namespace WildFarm.Core
{
    public class Engine
    {
        private BirdFactory birdFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private List<Animal> animals;
        private Animal animal;


        public Engine()
        {
            this.birdFactory = new BirdFactory();
            this.felineFactory = new FelineFactory();
            this.mammalFactory = new MammalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalInfo = input.Split();
                    string[] foodInfo = Console.ReadLine().Split();

                    string animalType = animalInfo[0];
                    string animalName = animalInfo[1];
                    double animalWeight = double.Parse(animalInfo[2]);

                    if (animalType == "Hen" || animalType == "Owl")
                    {
                        double wingSize = double.Parse(animalInfo[3]);
                        animal = this.birdFactory.CreateBird(animalType, animalName, animalWeight, wingSize);
                    }
                    else if (animalType == "Cat" || animalType == "Tiger")
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];
                        animal = this.felineFactory.CreateFeline(animalType, animalName, animalWeight, livingRegion, breed);
                    }
                    else if (animalType == "Mouse" || animalType == "Dog")
                    {
                        string livingRegion = animalInfo[3];
                        animal = this.mammalFactory.CreateMammal(animalType, animalName, animalWeight, livingRegion);
                    }

                    string foodType = foodInfo[0];
                    int foodQuantity = int.Parse(foodInfo[1]);
                    var food = this.foodFactory.CreateFood(foodType, foodQuantity);

                    animals.Add(animal);
                    animal.ProduceSound();
                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
