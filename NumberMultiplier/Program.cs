using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a comma seperated list of values");
            var Input = Console.ReadLine();
            var Array = Input.Split(',');

            Console.WriteLine("Should we (1) Multiply the numbers, or (2) Square them in place? (1/2)");
            var Mode = Console.ReadLine();

            if(int.Parse(Mode) == 1)
            {
                var Output = 1;

                foreach (var Item in Array)
                {
                    Output *= int.Parse(Item);
                }

                Console.WriteLine($"Results: {Output}");
            }
            else if(int.Parse(Mode) == 2)
            {
                var NewArray = new int[Array.Length];

                for (var i = 0; i < Array.Length; i++)
                {
                    var CurrentNumber = Convert.ToInt32(Array[i]);
                    NewArray[i] = CurrentNumber * CurrentNumber;
                }

                Console.WriteLine($"Results: {string.Join(',', NewArray)}");
            }
            else
            {
                Console.WriteLine("That was not a 1 or a 2. Please try again.");
            }
            
            Console.ReadLine();
        }
    }
}
