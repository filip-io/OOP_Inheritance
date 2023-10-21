using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals.Reptiles
{
    // Declaration of subclass derived from sub class Reptile

    internal class Alligator : Reptile
    {
        // Declaration of a unique property

        public string ColorShade { get; set; }

        public Alligator(string sound, string species, string color, string diet, int lifespan, bool coldblooded, string colorShade)
            : base(sound, species, color, diet, lifespan, coldblooded)
        {
            ColorShade = colorShade;
        }


        // Unique method

        public void LikesFreshWater()
        {
            Console.WriteLine($"*The {ColorShade} alligator lurks in the flooded grasslands*");
        }
    }
}
