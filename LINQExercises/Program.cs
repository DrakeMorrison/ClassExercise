using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restriction/Filtering Operations
            // Find the words in the collection that start with the letter 'L'
            var fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var LFruits = fruits.FindAll(fruit => fruit.StartsWith("L"));
            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            var sampleNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = sampleNumbers.Where(n => n % 4 == 0 || n % 6 == 0);
            foreach (var n in fourSixMultiples)
            {
                Console.WriteLine(n);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            var names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

            names.Sort();
            names.Reverse();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96, 102
                };

            numbers.Sort();
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            Console.WriteLine(numbers2.Count());

            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };

            Console.WriteLine(purchases.Sum());

            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };

            Console.WriteLine(prices.Max());

            List<int> wheresSquaredo = new List<int>()
                {
                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                };

            var squareDo = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);
            foreach (var number in squareDo)
            {
                Console.WriteLine($"Non-square number: {number}");
            }

            // Build a collection of customers who are millionaires
            var customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };


            // Given the same customer set, display how many millionaires per bank.
            // Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            var banks1 = from c in customers
                        group c.Balance by c.Bank into g
                        select new { Bank = g.Key, balances = g.ToList() };

            foreach (var thing in banks1)
            {
                Console.WriteLine($"{thing.Bank}: {thing.balances.Count()}");
            }

        Console.ReadLine();

            /*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/

            // Create some banks and store in a List
            List<Bank> banks2 = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            var millionaireReport = from customer in customers
                                    join bank in banks2 on customer.Bank equals bank.Symbol into g
                                    select new { Customer = customer, BankInfo = g };
                                    
        foreach (var customer in millionaireReport)
            {
                Console.WriteLine($"{customer.Customer.Name} at ");
                foreach (var bank in customer.BankInfo)
                {
                    Console.WriteLine(bank.Name);
                }
            }

            Console.ReadLine();

        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    // Define a bank
    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }
}
