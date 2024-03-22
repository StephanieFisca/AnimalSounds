using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    // Animal class
    class Animal
    {
        // Properties
        public string Type { get; }
        public string Sound { get; }

        /*Constructor with parameters that initialises the type and sound
        of an animal */
        public Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        // Method to make the animal sound
        public void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }

    }

    // MatchSoundToAnimal class to generate animal sounds
    class MatchSoundToAnimal
    {
        //Generates the sound an animal makes
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
            // Get the list of animals with sounds
            List<Animal> animals = MatchSoundToAnimal.GenerateAnimalSounds();

            // Iterate through all animals and generates their corresponding sound
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}