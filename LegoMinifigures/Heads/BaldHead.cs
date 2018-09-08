using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class BaldHead : Head
    {
        public override bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }
       
        public override void Talk()
        {
            Console.WriteLine("talking head I am");
        }
    }
}
