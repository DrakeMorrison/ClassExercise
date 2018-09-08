using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of letters");
            var Input = Console.ReadLine();
            var LowerInput = Input.ToLower();
            var Output = "";
            var Counter = 0;

            foreach(char Letter in LowerInput)
            {
                var TempString = new string(Letter, Counter);
                Output += Letter.ToString().ToUpper();
                Output += TempString;

                if (LowerInput[LowerInput.Length - 1] != Letter)
                {
                    Output += "-";
                }

                Counter++;
            }
            Console.WriteLine($"Results: {Output}");
            Console.ReadLine();
        }
    }
}
