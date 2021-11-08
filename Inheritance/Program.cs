using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class         




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            // example of creating bird in the main program
            var cryton = new Bird();

            cryton.IsLiving = true;
            cryton.Name = "Cryton";
            cryton.Age = 175;            
            cryton.IsWarmBlooded = true;
            cryton.HasFeathers = true;
            cryton.Legs = 2;
            cryton.Habitat = "Amazon Forrest";
            cryton.HasVertibrate = true;

            Console.WriteLine($"{cryton.Name}, is a rare bird that lives in the {cryton.Habitat}. It lives to be {cryton.Age}.");
            Console.WriteLine();
            Console.WriteLine($"It is {cryton.IsWarmBlooded} that {cryton.Name} is warm blooded.");
            Console.WriteLine($"Do you think {cryton.Name} has feathers?\n");
            Console.WriteLine($"That is {cryton.HasFeathers}!!!!");
            Console.WriteLine($"Does {cryton.Name}, have a vertibrate?\n");
            Console.WriteLine($"That is also {cryton.HasVertibrate}!!!!!");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            ///created details in Reptile method to call
            var alligator = new Reptile() { Age = 80, FavoriteFood = "fish", HasTail = true, Habitat = "swamp", IsColdBlooded = true, Name = "Alligator"};
            

            alligator.PrintDetails();
        }
    }
}
