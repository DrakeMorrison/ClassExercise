using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legs
{
    class Legs
    {
        public int Length { get; set; } = 34;
        public bool HasPants { get; set; } = true;
        public string ShoeColor { get; set; } = "";
        public string MainColor { get; set; } = "";

        public virtual void Walk()
        {
            Console.WriteLine($"The {MainColor} legs walker around the office");
         }

        public virtual void Kick(Minifigure minifigure)
        {
            Console.WriteLine($"Baby legs kicked {minifigure.Name}, the {minifigure.Description}.");
        }
    }
}
