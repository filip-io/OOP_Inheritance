using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Animals.Reptiles
{
    // Declaration of subclass Reptile that inherits from Animal

    internal class Reptile : Animal
    {

        // Declaration of a unique property

        public bool Coldblooded { get; set; }

        public Reptile(string sound, string species, string color, string diet, int lifespan, bool coldblooded)
            : base(sound, species, color, diet, lifespan)
        {
            Coldblooded = coldblooded;
        }


        // Default values if no parameters are set upon initialization of new object

        public Reptile()
        {
            _sound = "*~* BRING ME FLESH! *~*";
            _species = "dragon";
            _color = "golden";
            _diet = "humans";
            _lifespan = 10000;
            Coldblooded = true;
        }


        // Unique method

        public void Sunbathe()
        {
            Console.WriteLine($"The {_species} are enjoying the radiant sun!");
        }


        // Method to print default values

        public void PrintDefaultValues()
        {
            Console.WriteLine($"The {_species} roars: \t{_sound}");
            Console.WriteLine();
            Console.WriteLine($"This is a big bad {_species}!");
            Console.WriteLine($"It's {_color} scales sparkles!");
            Console.WriteLine($"The {_species} only want's to eat {_diet}.");
            Console.WriteLine($"It will continue to do so for at least {_lifespan:N0} years!");
            Console.WriteLine($"It's {Coldblooded}! The {_species} needs the sun to heat up his blood!");
        }
    }
}
