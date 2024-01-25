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
            Console.WriteLine("Bird:\n-------------------------------");
            Bird borb = new Bird()
            {
                Species = "American Robin",
                Legs = 2,
                Tail = true,
                Color = "Brownish-gray upperparts, orange-red breast",
                Wingspan = 14,
                NestType = "cup shaped",
                BeakShape = "thin and pointed",
                Migratory = true
            };
            borb.DisplayInfoBird();

            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("Reptile:\n-------------------------------");
            Reptile beard = new Reptile()
            {
                Species = "Bearded Dragon",
                Legs = 4,
                Tail = true,
                Color = "Various colors, including shades of brown, tan, red, and yellow",
                Habitat = "deserts and woodlands",
                ColdBlooded = true,
                Diet = "Omnivorous",
                EggLaying = true
            };
            beard.DisplayInfoRep();
        }
    }
}
