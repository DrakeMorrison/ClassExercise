using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class NathanHead : Head
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt n Peppa"; } }
        public string Texture { get; set; }

        public override void Talk()
        {
            Console.WriteLine("Blah Blah Blah");
        }
    }
}
