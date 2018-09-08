using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    abstract class Head
    {
        public abstract bool HasHair { get; }

        public abstract void Talk();

        public virtual void Eat()
        {
            Console.WriteLine("Nom Nom");
        }

    }
}
