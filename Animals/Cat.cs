using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals
{

    // Declaration of subclass Cat that inherits from base class Animal

    internal class Cat : Animal
    { 

        // Declaration of a unique property

        public bool _evil { get; set; }

        public Cat(string sound, string species, string color, string diet, int lifespan, bool evil)
            : base(sound, species, color, diet, lifespan)
        {
            _evil = evil;
        }


        // Default values if no values are set upon initialization of new object

        public Cat()
        {
            _sound = "*~ RAWR! *~";
            _species = "kitten";
            _color = "purple";
            _diet = "spiders";
            _lifespan = 9000;
            _evil = true;
        }


        // Unique method

        public void Chase()
        {
            Console.WriteLine($"*The {_species} chases the dog!*");
        }
    }
}   
