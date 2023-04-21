using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Birds myBird = new Birds();
            {
                myBird.CanFly = true;
                myBird.HasWings = true;
                myBird.DoesMigrate = true;
                myBird.HasBeak = true;


            };

            Reptile myLizard = new Reptile();
            {


                myLizard.IsColdBlooded = true;
                myLizard.CanGrowLimbs = true;
                myLizard.Eyecolor = "dark green";
                myLizard.HasScales = true;

            };

            var MyAnimals = new Animal[] { myBird, myLizard };

            foreach (var animal in MyAnimals)
            {
                Console.WriteLine($"Animal: {animal}");
                Console.WriteLine($"Alive:{animal.CanBreath}");
                Console.WriteLine($" Is Born:{animal.IsBorn}");
                Console.WriteLine($" Number of Legs:{animal.HasLegs}");
                Console.WriteLine($" Eats:{animal.Eats}");
                Console.WriteLine("");

            }



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}





// TODO Be sure to follow best practice when creating your classes

// DONE-Create a class Animal
// give this class 4 members that all Animals have in common


// DONE-Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class

// DONE-Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class

/*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */