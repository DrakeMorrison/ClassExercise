using LegoMinifigures.Heads;
using LegoMinifigures.Torsos;
using System;
using System.Collections.Generic;
using System.Text;
using Leggers = LegoMinifigures.Legs.Legs;

namespace LegoMinifigures
{
    class Minifigure
    {
        private readonly Head _head;
        private readonly Torso _torso;
        private readonly Leggers _legs;

        public string Name { get; }
        public string Description
        {
            get
            {
                return $"{(_head.HasHair ? "Hairy" : "Bald")} {_torso.Color} {_torso.NumberOfArms} armed thing";
            }
        }

        public Minifigure(string name, Head head, Torso torso, Leggers legs)
        {
            Name = name;
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Karate(Minifigure target)
        {
            _legs.Kick(target);
        }

        public void Greet()
        {
            _head.Talk();
            _torso.Wave();
        }

        public void TakeABreak()
        {
            switch (_torso)
            {
                case BirdTorso bird:
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile:
                    reptile.Dance();
                    break;
                case Torso torso:
                    Console.WriteLine($"The boring torso was {torso.Color} and has {torso.NumberOfArms} arms.");
                    break;
            }
        }
    }
}
