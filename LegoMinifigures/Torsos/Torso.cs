using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Torsos
{
    class Torso
    {
        public string Color { get; set; }
        public int NumberOfArms { get; set; }
        public bool HasClothes { get; set; }

        public void Wave()
        {
            if (NumberOfArms >= 1)
            {
                Console.WriteLine("*Waves*");
            }
        }
    }
}
