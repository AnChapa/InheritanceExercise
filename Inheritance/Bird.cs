using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public double Wingspan {  get; set; }
        public string NestType { get; set; }
        public string BeakShape { get; set; }
        public bool Migratory { get; set; }
        public void DisplayInfoBird()
        {
            Console.WriteLine($"The {Species} is a {(Migratory ? "migratory" : "non migratory")} bird that creates a {NestType} nest.");
            Console.WriteLine($"{Species} has a {Wingspan} inch wingspan and has a {BeakShape} beakshape for eating certain foods.");
            Console.WriteLine($"{Species} is {Color} color, has {Legs} legs, and {(Tail ? "has a tail." : "does not have a tail.")}");
        }
    }

}
