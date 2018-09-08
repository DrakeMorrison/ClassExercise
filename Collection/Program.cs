using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {

        void SquaredRandoms(string[] args)
        {
            var random = new Random();
            var list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(51));
            }

            var squaredList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                squaredList.Add(list[i] * list[i]);
            }

            squaredList.RemoveAll(x => x % 2 != 0);
        }

        static void Planets()
        {
            var planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");
        }

        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("older sister", new Dictionary<string, string>(){
                {"name", "Ashlyn"},
                 {"age", "21"}
            });

            myFamily.Add("younger sister", new Dictionary<string, string>()
            {
                {"name", "Izzy" },
                {"age", "17" }
            });

            foreach (var key in myFamily.Keys)
            {
                var domString = $"{myFamily[key]["name"]} is my {key} and is {myFamily[key]["age"]} years old";
                Console.WriteLine(domString);

            }

            Console.ReadLine();
        }
    }
}
