using System;
using System.Collections.Generic;

namespace RomanNumeralConverter
{
    public class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, so I can make it a Roman Numeral");

            var numberEntered = int.Parse(Console.ReadLine());

            var converter = new RomanConverter();

            var result = converter.IntToRoman(numberEntered);

            Console.WriteLine(result);            
        }        
    }

    public class RomanConverter
    {

        public Dictionary<string, int> RomanMap = new Dictionary<string, int>()
        {
            { "I", 1},
                { "IV", 4 },
                { "V", 5 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 }
        };

        public string IntToRoman(int input)
        {
            throw new NotImplementedException();
        }

        public int RomanToInt(string input)
        {
            throw new NotImplementedException();
        }
    }
}
