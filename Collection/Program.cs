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

        static void FamilyDictionary()
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

        public void KillNickelback()
        {
            var goodSongs = new List<Song>();
            var allSongs = new HashSet<Song>();

            allSongs.Add(new Song("Nickelback", "How you remind me"));
            allSongs.Add(new Song("Nickelback", "Far Away"));
            allSongs.Add(new Song("Nickelback", "Rockstar"));
            allSongs.Add(new Song("Nickelback", "Photograph"));
            allSongs.Add(new Song("Breaking Benjamin", "The Diary of Jane"));
            allSongs.Add(new Song("Breaking Benjamin", "I Will Not Bow"));
            allSongs.Add(new Song("Breaking Benjamin", "Angels Fall"));

            foreach (Song track in allSongs)
            {
                if (track.Artist != "Nickelback")
                {
                    goodSongs.Add(track);
                }
            }

            foreach (Song track in goodSongs)
            {
                Console.WriteLine($"{track.Artist}, {track.Name}");
            }

            Console.ReadLine();
        }

        public void HashSets()
        { // make hashset for showroom
            var showRoom = new HashSet<string>();

            // add cars to showroom

            showRoom.Add("Tesla");
            showRoom.Add("Prius");
            showRoom.Add("Lambo");
            showRoom.Add("Corvette");

            Console.WriteLine($"There are {showRoom.Count} cars in the showroom.");

            showRoom.Add("Corvette"); // attempt to add duplicate in HashSet to demonstrate futility.

            Console.WriteLine($"There are {showRoom.Count} cars in the showroom.");

            // make new HashSet of cars

            var usedLot = new HashSet<string>()
            {
                "Porsche",
                "SmartCar"
            };

            // add usedLot to showRoom and remove one car

            showRoom.UnionWith(usedLot);
            showRoom.Remove("SmartCar");

            // make new HashSet of cars

            var junkyard = new HashSet<string>()
            {
                "Porsche",
                "Prius", // duplicate in showroom
                "Jaguar",
                "Audi v8"
            };

            showRoom.UnionWith(junkyard);

            foreach (string showCar in showRoom)
            {
                Console.WriteLine(showCar);
            }


            Console.ReadLine();
        }

        public class Song
        {
            public string Artist { get; set; }
            public string Name { get; set; }

            public Song(string artist, string name)
            {
                Artist = artist;
                Name = name;
            }
        }

        public void TupleTransactions()
        { // make list for transactions
            var transactions = new List<(string, double, int)>();

            // add transactions

            transactions.Add(("product1", 10.23, 3));
            transactions.Add(("product2", 11.50, 2));
            transactions.Add(("product3", 12.76, 1));
            transactions.Add(("product4", 13.56, 2));
            transactions.Add(("product5", 14.43, 3));

            var itemsSold = 0;
            var revenue = 0.0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // add up items sold
                itemsSold += t.quantity;
                // add up revenue of items
                revenue += (t.quantity * t.amount);
            }

            Console.WriteLine($@"
                items sold today: {itemsSold}
                total revenue: ${revenue}
            ");

            Console.ReadLine();
        }

        static void Main() // Stock Purchase Dictionaries
        { // set up stock dictionary
            var stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("GE", "General Electric");

            // make new dictionary for purchases

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            // add purchases

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 10, price: 23.21));
            purchases.Add((ticker: "AAPL", shares: 122, price: 17.87));
            purchases.Add((ticker: "GM", shares: 48, price: 19.02));

            // make dictionary for report

            var report = new Dictionary<string, double>();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                var newValuation = purchase.shares * purchase.price;
                var purchaseKey = stocks[purchase.ticker];
                // Does the company name key already exist in the report dictionary?
                if (report.ContainsKey(purchaseKey))
                {                // If it does, update the total valuation
                    report[purchaseKey] += newValuation;
                }
                else                // If not, add the new key and set its value
                {
                    report.Add(purchaseKey, newValuation);
                }
            }
        }
    }
}