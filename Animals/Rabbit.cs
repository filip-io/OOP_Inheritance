using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals
{
    // Declaration of subclass Rabbit that inherits from base class Animal

    internal class Rabbit : Animal
    {
        // Declaration of a unique property

        public bool _bigFeeted { get; set; }

        public Rabbit(string sound, string species, string color, string diet, int lifespan, bool bigfeeted)
            : base(sound, species, color, diet, lifespan)
        {
            _bigFeeted = bigfeeted;
        }


        // Default values if no parameters are set upon initialization of new object

        public Rabbit()
        {
            _sound = "*~ Wake up... follow me.. ~*";
            _species = "bunny";
            _color = "white";
            _diet = "bananas";
            _lifespan = 66;
            _bigFeeted = false;
        }


        // Unique method

        public void Jumps()
        {
            Console.WriteLine("*The rabbit jumps into it's rabbit hole!*");
        }
    }
}
