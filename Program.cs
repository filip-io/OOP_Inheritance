

// Filip Nilsson NET23


using OOP_Inheritance.Animals;
using OOP_Inheritance.Animals.Reptiles;

namespace Zoo_Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit Skuttan = new Rabbit();
            Skuttan.AnimalInfo();


            Cat Bosse = new Cat("\t\t*~* miaow *~*", "cat", "black", "fish", 15, true);

            Alligator Melker = new Alligator("\t*~* HISSSS! *~*", "alligator", "dark green", "meat", 50, true, "dark");

            Crocodile Leifi = new Crocodile("\t*~* GRUNTING! *~*", "crocodile", "grey-green", "meat", 50, true, "triangular");


            Console.WriteLine();
            Console.WriteLine();


            Bosse.MakeSound();  
            Melker.MakeSound();
            Leifi.MakeSound();


            Console.WriteLine();
            Console.WriteLine();


            Reptile Pelle = new Reptile();
            Pelle.PrintDefaultValues();


            Console.ReadKey();  
        }
    }
}