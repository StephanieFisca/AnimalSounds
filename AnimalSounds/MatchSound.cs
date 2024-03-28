using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    /* MatchSound class to generate animal sounds */
    public abstract class MatchSound
    {
        /* Generates the sound an animal makes */
        public static List<Animal> GenerateAnimalSounds()
        {
            /* Returns a list of animals and their sounds */
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
}
