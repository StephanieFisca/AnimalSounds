using System;
using System.Collections.Generic;

namespace AnimalSoundsOOP
{
    // Animal class representing each animal
    class Animal
    {
        // Properties
        public string Type { get; }
        public string Sound { get; }

        // Constructor to initialize Type and Sound of the animal
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

    // AnimalSoundGenerator class to generate animal sounds
    class AnimalSoundGenerator
    {
        // Method to generate a list of Animal objects with predefined sounds
        public static List<Animal> GenerateAnimalSounds()
        {
            return new List<Animal>
            {
                new Animal("Dog", "Bark"),
                new Animal("Cat", "Meow"),
                new Animal("Elephant", "Trumpet")
                new Animal("Cow ", "Moo")
                new Animal("Horse", "Neigh")
                new Animal("Duck", "Quack")
                new Animal("Lion", "Roar")
                new Animal("Sheep", "Baa")
                new Animal("Snake", "Ssss")
                
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get the list of animals with sounds
            List<Animal> animals = AnimalSoundGenerator.GenerateAnimalSounds();

            // Iterate through the list of animals and make each animal sound
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}
