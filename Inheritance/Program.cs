using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            
            var bird = new Bird();

            bird.WingSpan = 24;
            bird.BeackColor = "Black";
            bird.DoesSing = false;
            bird.DoesFly = true;
            bird.Name = "Crow";
            bird.Weight = 3;
            bird.BloodType = "Unknown";
            bird.Age = 5;

            Console.WriteLine($"The {bird.Name} is {bird.Age} years old with a wingspan of {bird.WingSpan} inches. " +
                              $"Its beak color is {bird.BeackColor} and it weighs {bird.Weight} lbs.");


            Console.WriteLine();
            var reptile = new Reptile();

            reptile.Name = "Larry";
            reptile.Weight = 13;
            reptile.BloodType = "cold";
            reptile.Age = 3;
            reptile.ReptileClass = "Tortoise";
            reptile.HasLaidEggs = false;
            reptile.HasScales = true;
            reptile.HasScutes = false;

            Console.WriteLine($"{reptile.Name} the {reptile.ReptileClass} is {reptile.Age} years old, {reptile.BloodType} blooded, and weighs {reptile.Weight} lbs.");




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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
