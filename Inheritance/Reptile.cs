using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Habitat {  get; set; }
        public bool ColdBlooded {  get; set; }
        public string Diet {  get; set; }
        public bool EggLaying { get; set; }

        public void DisplayInfoRep()
        {
            Console.WriteLine($"The {Species} is a {(ColdBlooded ? "coldblooded" : "warmblooded")} reptile that lives in {Habitat} environment.");
            Console.WriteLine($"{Species} is a {Diet} eater and  {(EggLaying? "lays eggs": "has live births")} to reproduce.");
            Console.WriteLine($"{Species} is {Color} color, has {Legs} legs, and {(Tail ? "has a tail." : "does not have a tail.")}");
        }
    }
}
