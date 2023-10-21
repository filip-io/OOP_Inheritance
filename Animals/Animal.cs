using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals
{

    // Declaration of the base class

    internal class Animal
    {
        protected string _sound { get; set; }
        protected string _species { get; set; }
        protected string _color { get; set; }
        protected string _diet { get; set; }
        protected int _lifespan { get; set; }


        // Base class constructor used by inheriting classes

        public Animal(String sound, string species, string color, string diet, int lifespan)
        {
            _sound = sound;
            _species = species;
            _color = color;
            _diet = diet;
            _lifespan = lifespan;
        }


        // Default values for the constructor if no values are set upon initialization of new objects

        public Animal()
        {
            _sound = "*~ SHOUTING! *~";
            _species = "unknown";
            _color = "translucent";
            _diet = "carbs";
            _lifespan = 9000;
        }


        // Declaration of three methods available to all children of the base class

        public void MakeSound()
        {
            Console.WriteLine($"The {_species} makes a noise: {_sound}");
        }
 
        public void Eat()
        {
            Console.WriteLine($"The {_species} eats: {_diet}");
        }

        public virtual void Move()
        {
            Console.WriteLine($"The {_species} is on the move.");
        }

        public void AnimalInfo()
        {
            Console.WriteLine($"Sound: {_sound}\nSpecies: {_species}\nColor: {_color}\nDiet: {_diet}\nLifespan: {_lifespan}");
        }
    }
}
