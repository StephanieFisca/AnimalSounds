using System;
using System.Collections.Generic;

namespace AnimalSounds
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Get list of animals and their sounds */
            List<Animal> animals = MatchSound.GenerateAnimalSounds();

            /* Iterate through each animal and make the corresponding sound */
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            /*New line in terminal */
            Console.ReadLine();

        }
    }
}