using LegoMinifigures.Heads;
using LegoMinifigures.Legs;
using LegoMinifigures.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();
            var reptileBody = new ReptilianTorso();
            reptileBody.Color = "Brown";
            var babyLegs = new BabyLegs();
            babyLegs.Length = 19;
            babyLegs.MainColor = "purple";
            babyLegs.ShoeColor = "Yellow";

            var nathan = new Minifigure("Steve", head, reptileBody, babyLegs);

            nathan.Greet();

            var head2 = new BaldHead();
            var birdBody = new BirdTorso();
            birdBody.Color = "pink";
            var manLegs = new BabyLegs();
            manLegs.Length = 19;
            manLegs.MainColor = "blue";
            manLegs.ShoeColor = "brown";

            var martin = new Minifigure("Martin", head2, birdBody, manLegs);

            martin.Greet();

            nathan.Karate(martin);
            nathan.TakeABreak();
            martin.TakeABreak();


            Console.ReadLine();
        }
    }
}
