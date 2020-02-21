using System;
using System.Diagnostics;
using System.Numerics;

namespace Factorial_Finder
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Fair warning; this program uses the BigInteger structure. That means that it will allow any number of any size until the system runs out of memory.");
            Console.WriteLine("Other structures, such as decimal, will not work out the factorial of any number larger than 27 before they throw an overflow exception.");
            Console.WriteLine("For reference, calculating the factorial of 1,000,000 took 16 minutes and 22 seconds on a Ryzen 5 3550H.");
            Console.WriteLine("\n\nPlease enter a number to find the factorial of.");

            var input = Console.ReadLine();
            
            if (BigInteger.TryParse(input, out var numberToFindFactorialOf) == false) // Check if the input cannot be parsed as a number, meaning it is not exclusively a number. If it can be, create a variable.
            {
                Console.WriteLine("You did not enter a number."); // If it can't, tell the user off and quit out.
                Environment.Exit(1);
            }

            BigInteger result = numberToFindFactorialOf;

            for (BigInteger number = 1; number < numberToFindFactorialOf; number++)
            {
                result = checked(result * number);
            }

            Console.WriteLine($"The factorial of {numberToFindFactorialOf} is {result.ToString()}");
        }
    }
}
