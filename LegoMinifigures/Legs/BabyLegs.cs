using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legs
{
    class BabyLegs : Legs
    {
        public BabyLegs()
        {
            Length = 10;
            HasPants = false;
        }

        public override void Walk()
        {
            if (Length > 18)
                Console.WriteLine($"The {MainColor} baby legs wobble-strutted around the playpen in {ShoeColor} shoes.");
            else
                Console.WriteLine($"The {MainColor} baby legs crawled around the playpen.");
        }

        public override void Kick(Minifigure minifigure)
        {
            Console.WriteLine($"Baby legs kicked {minifigure.Name}, the {minifigure.Description}.");
        }
    }
}
