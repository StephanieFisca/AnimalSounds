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

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Animal objects
            List<Animal> animals = new List<Animal>
            {
                new Animal("Dog", "Bark"),
                new Animal("Snake", "Ssss"),
                new Animal("Horse", "Neigh")
            };

            // Iterate through the list of animals and make each animal sound
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine();
        }
    }
}