using AnimalSounds.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Animal : IAnimal
    {
            /* Animal Class Properties */
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
}
