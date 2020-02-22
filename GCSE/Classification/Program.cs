using System;
using System.Collections.Generic;
using System.Linq;

namespace Classification
{
    public sealed class Program
    {
        public static void Main()
        {
            var userAnimal = new Animal
            {
                FourLegs = AskQuestion("Does the animal have four legs?").Value,
                EatsMeat = AskQuestion("Does the animal eat meat?").Value,
                LivesInWater = AskQuestion("Does the animal live in water?").Value,
                Insect = AskQuestion("Is the animal a type of insect?").Value,
                Feathers = AskQuestion("Does the animal have feathers?").Value,
                Stripey = AskQuestion("Is the animal stripey?").Value,
                FoundInBritain = AskQuestion("Can the animal be found in Britain?").Value,
                BoughtInPetShop = AskQuestion("Can the animal be bought in a pet shop?").Value,
                CanSwim = AskQuestion("Can the animal swim?").Value,
                CanFly = AskQuestion("Can the animal fly?").Value
            };

            var names = new string[] { };

            foreach (var animal in Animals.Where(animal => animal.IsIdenticalTo(userAnimal)))
            {
                names = animal.Name;
            }

            if (names.Length > 0)
            {
                var animalOrAnimals = names.Length == 1 ? "animal" : "animals";
                var isOrAre = names.Length == 1 ? "is" : "are";

                Console.WriteLine($"The {animalOrAnimals} you might be thinking of {isOrAre}:");

                foreach (var name in names)
                {
                    Console.WriteLine($"{name}");
                }
            }
            else
            {
                Console.WriteLine("No animals matching that description were found!");
            }
        }

        private static readonly List<Animal> Animals = new List<Animal>()
        {
            new Animal()
            {
                FourLegs = true,
                EatsMeat = false,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Horse", "Cow", "Sheep", "Pig" }
            },

            new Animal()
            {
                FourLegs = true,
                EatsMeat = true,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = true,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Dog", "Cat" }
            },

            new Animal()
            {
                FourLegs = true,
                EatsMeat = true,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Lion" }
            },

            new Animal()
            {
                FourLegs = true,
                EatsMeat = true,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = true,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Tiger" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = true,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = false,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Whale" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = true,
                LivesInWater = true,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = false,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Dolphin", "Octopus" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = true,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Seal" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = true,
                LivesInWater = false,
                Insect = false,
                Feathers = true,
                Stripey = false,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Penguin" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = false,
                Insect = false,
                Feathers = true,
                Stripey = false,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Ostrich" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = false,
                Insect = false,
                Feathers = true,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = true,
                Name = new[] { "Sparrow" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = false,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = true,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Spider" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = false,
                Insect = true,
                Feathers = false,
                Stripey = false,
                FoundInBritain = true,
                BoughtInPetShop = true,
                CanSwim = false,
                CanFly = false,
                Name = new[] { "Ant", "Termite" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = false,
                LivesInWater = false,
                Insect = true,
                Feathers = false,
                Stripey = true,
                FoundInBritain = true,
                BoughtInPetShop = false,
                CanSwim = false,
                CanFly = true,
                Name = new[] { "Bee", "Wasp" }
            },

            new Animal()
            {
                FourLegs = false,
                EatsMeat = true,
                LivesInWater = true,
                Insect = false,
                Feathers = false,
                Stripey = false,
                FoundInBritain = false,
                BoughtInPetShop = false,
                CanSwim = true,
                CanFly = false,
                Name = new[] { "Squid" }
            }
        };

        private static bool? AskQuestion(string question)
        {
            while (true)
            {
                Console.WriteLine(question);

                var response = Console.ReadLine();

                if (response.IsFormattedCorrectly())
                {
                    return response != null && response.ToLower() == "yes";
                }

                Console.WriteLine("Please only enter \"yes\" or \"no\".");
            }
        }
    }

    public sealed class Animal
    {
        public bool FourLegs { get; set; }
        public bool EatsMeat { get; set; }
        public bool LivesInWater { get; set; }
        public bool Insect { get; set; }
        public bool Feathers { get; set; }
        public bool Stripey { get; set; }
        public bool FoundInBritain { get; set; }
        public bool BoughtInPetShop { get; set; }
        public bool CanSwim { get; set; }
        public bool CanFly { get; set; }
        public string[] Name { get; set; }
    }

    public static class Validation
    {
        public static bool IsFormattedCorrectly(this string response)
        {
            if (string.IsNullOrWhiteSpace(response)) return false;
            return response == "yes" || response == "no";
        }

        public static bool IsIdenticalTo(this Animal animal, Animal comparingTo)
        {
            return animal.FourLegs == comparingTo.FourLegs
                   && animal.EatsMeat == comparingTo.EatsMeat
                   && animal.LivesInWater == comparingTo.LivesInWater
                   && animal.Insect == comparingTo.Insect
                   && animal.Feathers == comparingTo.Feathers
                   && animal.Stripey == comparingTo.Stripey
                   && animal.FoundInBritain == comparingTo.FoundInBritain
                   && animal.BoughtInPetShop == comparingTo.BoughtInPetShop
                   && animal.CanSwim == comparingTo.CanSwim
                   && animal.CanFly == comparingTo.CanFly;
        }
    }
}
