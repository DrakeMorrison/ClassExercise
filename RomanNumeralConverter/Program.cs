using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, so I can make it a Roman Numeral");

            var numberEntered = int.Parse(Console.ReadLine());

            var converter = new RomanConverter();

            var romanNumeralResult = converter.IntToRoman(numberEntered);

            Console.WriteLine(romanNumeralResult);
            Console.ReadLine();

            Console.WriteLine("now give me a number made with roman numerals in all caps");

            var input = Console.ReadLine();

            var integerResult = converter.RomanToInt(input);

            Console.WriteLine(integerResult);
            Console.ReadLine();
        }
    }

    public class RomanNumeral
    {
        public int Value { get; set; }
        public string Numeral { get; set; }

        public RomanNumeral(string numeral, int value)
        {
            Value = value;
            Numeral = numeral;
        }
    }

    public class RomanCharacter
    {
        public int Value { get; set; }
        public char Numeral { get; set; }

        public RomanCharacter(char numeral, int value)
        {
            Value = value;
            Numeral = numeral;
        }
    }

    public class RomanConverter
    {

        public List<RomanCharacter> RomanMapAscending = new List<RomanCharacter>()
        {
            new RomanCharacter('I', 1),
            //new RomanCharacter('IV', 4 ),
            new RomanCharacter( 'V', 5 ),
            //new RomanCharacter( 'IX', 9 ),
            new RomanCharacter( 'X', 10 ),
            //new RomanCharacter( 'XL', 40 ),
            new RomanCharacter( 'L', 50 ),
            //new RomanCharacter( 'XC', 90 ),
            new RomanCharacter( 'C', 100 ),
            //new RomanCharacter( 'CD', 400 ),
            new RomanCharacter( 'D', 500 ),
            //new RomanCharacter( 'CM', 900 ),
            new RomanCharacter( 'M', 1000 )
        };

        public List<RomanNumeral> RomanMapDescending = new List<RomanNumeral>()
        {
            new RomanNumeral( "M", 1000 ),
            new RomanNumeral( "CM", 900 ),
            new RomanNumeral( "D", 500 ),
            new RomanNumeral( "CD", 400 ),
            new RomanNumeral( "C", 100 ),
            new RomanNumeral( "XC", 90 ),
            new RomanNumeral( "L", 50 ),
            new RomanNumeral( "XL", 40 ),
            new RomanNumeral( "X", 10 ),
            new RomanNumeral( "IX", 9 ),
            new RomanNumeral( "V", 5 ),
            new RomanNumeral("IV", 4 ),
            new RomanNumeral("I", 1)
        };

        public string IntToRoman(int input)
        {
            var numberToBuild = input;
            var output = "";
            int howManyOfNumeral;
            int remainder;

            for (var i = 0; i < RomanMapDescending.Count; i++)
            {
                howManyOfNumeral = Math.Abs(numberToBuild / RomanMapDescending[i].Value);
                remainder = numberToBuild % RomanMapDescending[i].Value;

                for (int y = 0; y < howManyOfNumeral; y++)
                {
                    output += RomanMapDescending[i].Numeral;
                }

                numberToBuild = remainder;
            }

            return output;
        }

        public int RomanToInt(string input)
        {
            var romanNumberText = input;
            var romanNumbers = romanNumberText.ToCharArray().ToList();
            var output = 0;

            for (int i = 0; i < RomanMapAscending.Count; i++)
            {
                //while (romanNumbers.Count != 0 && romanNumbers[romanNumbers.Count - 1] == RomanMapAscending[i].Numeral)
                while (romanNumbers.Count != 0 && romanNumbers.Contains(RomanMapAscending[i].Numeral))
                {
                    if (romanNumbers[romanNumbers.Count - 1] == RomanMapAscending[i].Numeral)
                    {
                        output += RomanMapAscending[i].Value;
                        romanNumbers.RemoveAt(romanNumbers.Count - 1);
                    }
                    else
                    {
                        output -= RomanMapAscending[i].Value;
                        var indexor = romanNumbers.IndexOf(RomanMapAscending[i].Numeral);
                        romanNumbers.RemoveAt(indexor);
                    }
                }
            }

            return output;
        }
    }
}
