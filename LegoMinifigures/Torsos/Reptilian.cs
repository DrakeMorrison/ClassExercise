using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Torsos
{
    class ReptilianTorso : Torso
    {
        public string ScaleShape { get; set; }

        public void Dance()
        {
            Console.WriteLine($"*Breakdances vigorously in {Color}*");
        }

        public void Twist()
        {
            Console.WriteLine("A little bit louder now.");
        }
    }
}
