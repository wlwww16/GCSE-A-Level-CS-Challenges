using System;

namespace Fruit_Machine
{
    public sealed class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the fruit machine! These are the rules:");
            Console.WriteLine("1) You start with £1.00 credit.\n2) Each roll costs 20p.\n3) Rolling two identical symbols awards 50p but two skulls will take away £1.00.");
            Console.WriteLine("4) Rolling three identical symbols awards £1.00 (£5.00 for bells), but three skulls will take all of your money.");
            Console.WriteLine("5) Whenever prompted to press any key, pressing Q will quit the program.");

            var credits = 1.00;

            while (credits > 0) {
                Console.WriteLine($"\nYou have £{credits:0.00} worth of credit.");
                Console.Write("Press any key to roll > ");
                
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }

                credits -= 0.20;
                credits += Roll();
            }
        }

        public static double Roll()
        {
            return 0.50;
        }
    }
}
