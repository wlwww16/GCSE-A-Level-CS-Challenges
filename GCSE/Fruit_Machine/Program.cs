using System;
using System.Collections.Generic;
using System.Linq;

namespace Fruit_Machine
{
    public sealed class Program
    {
        private static readonly string[] Symbols = {
            "Cherry", "Bell", "Lemon", "Orange", "Star", "Skull"
        }; 
        
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
                    Console.WriteLine("\nThank you for playing!");
                    return;
                }

                credits -= 0.20;
                credits += Roll(credits);
            }

            Console.WriteLine("Unfortunately, you ran out of money. Thank you for playing!");
        }

        public static double Roll(double playerCredits)
        {
            var random = new Random();
            var symbols = new List<string>();

            for (var i = 0; i < 3; i++)
            {
                symbols.Add(Symbols[random.Next(0, Symbols.Length)]);
            }

            Console.WriteLine($"\nYou rolled: {symbols[0]}, {symbols[1]}, {symbols[2]}.");

            foreach (var symbol in symbols)
            {
                switch (symbol)
                {
                    case "Skull":
                        switch (symbols.Count(x => x == "Skull"))
                        {
                            case 2:
                                return -1;
                            case 3:
                                return -playerCredits;
                        }
                        break;
                    case "Bell":
                        switch (symbols.Count(x => x == "Bell"))
                        {
                            case 2:
                                return 0.50;
                            case 3:
                                return 5;
                        }
                        break;
                    default:
                        switch (symbols.Count(x => x == symbol))
                        {
                            case 2:
                                return 0.5;
                            case 3:
                                return 1;
                        }
                        break;
                }
            }

            return 0;
        }
    }
}
