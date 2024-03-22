using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    /* Animal Class */
    class Animal
    {
        /* Class properties */
        public string Type { get; }
        public string Sound { get; }

        /* Constructor that initialises the type and sound of an animal */
        public Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        /* Method that makes the animal sound */
        public void MakeSound()
        {
            Console.WriteLine($"{Type} makes the sound {Sound}");
        }
    }

    /* MatchSoundToAnimal class to generate animal sounds */
    class MatchSoundToAnimal
    {
        /* Generates the sound an animal makes */
        public static List<Animal> GenerateAnimalSounds()
        {
            return new List<Animal>
            {
                new Animal("Dog", "Bark"),
                new Animal("Snake", "Ssss"),
                new Animal("Horse", "Neigh"),
                new Animal("Cat", "Meow"),
                new Animal("Hyena", "Laugh")
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Get list of animals and their sounds */
            List<Animal> animals = MatchSoundToAnimal.GenerateAnimalSounds();

            /* Iterate through each animal and make the corresponding sound */
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();

        }
    }
}