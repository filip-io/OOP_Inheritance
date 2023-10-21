using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals.Reptiles
{
    // Declaration of subclass derived from sub class reptile

    internal class Crocodile : Reptile
    {
        // Declaration of a unique property

        protected string _snoutShape { get; set; }

        public Crocodile(string sound, string species, string color, string diet, int lifespan, bool coldblooded, string snoutshape)
            : base(sound, species, color, diet, lifespan, coldblooded)
        {
            _snoutShape = snoutshape;
        }


        // Unique method

        public void Hungry()
        {
            Console.WriteLine($"*The crocodile points it's {_snoutShape} snout at you and looks very hungry!*");
        }
    }
}
