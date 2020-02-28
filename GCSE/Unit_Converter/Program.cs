using System;

namespace Unit_Converter
{
    public sealed class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Would you like to convert [c]urrency, [t]emperature or [v]olume?");
                Console.WriteLine("Enter the letter in [brackets] corresponding to the action.");

                var action = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(action))
                {
                    switch (action.ToLower())
                    {
                        case "c":
                            CurrencyConversions.GetMoneyAndShowResult();
                            break;
                        case "t":
                            TemperatureConversions.GetTemperatureAndShowResult();
                            break;
                        case "v":
                            VolumeConversions.GetVolumeAndShowResult();
                            break;
                        default:
                            Console.WriteLine("You did not choose a recognised action.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You did not choose a recognised action.");
                }
            }
        }
    }

    public static class TemperatureConversions
    {
        public static void GetTemperatureAndShowResult()
        {
            while (true)
            {
                Console.Write("Please enter a temperature: ");

                if (double.TryParse(Console.ReadLine(), out var startingMeasurement))
                {
                    var startingUnit = GetStartingUnit();
                    var desiredUnit = GetDesiredUnit();

                    Console.WriteLine($"{startingMeasurement}{startingUnit[0].ToString().ToUpper()} is {startingMeasurement.ConvertToTemperature(desiredUnit, startingUnit)}{desiredUnit[0].ToString().ToUpper()}.");
                    return;
                }

                Console.WriteLine("You must enter a number for the temperature.");
            }
        }

        public static string GetStartingUnit()
        {
            while (true)
            {
                Console.WriteLine("Is this measurement in [k]elvin, [f]ahrenheit or [c]elsius?");
                Console.Write("Enter the letter in [brackets] corresponding to the unit.");

                var startingUnit = Console.ReadLine();

                switch (startingUnit)
                {
                    case "k":
                        return "kelvin";
                    case "f":
                        return "fahrenheit";
                    case "c":
                        return "celsius";
                }

                Console.WriteLine("You did not enter a recognised key.");
            }
        }

        public static string GetDesiredUnit()
        {
            while (true)
            {
                Console.WriteLine("Do you want the conversion in [k]elvin, [f]ahrenheit or [c]elsius?");
                Console.Write("Enter the letter in [brackets] corresponding to the unit.");

                var startingUnit = Console.ReadLine();

                switch (startingUnit)
                {

                    case "k":
                        return "kelvin";
                    case "f":
                        return "fahrenheit";
                    case "c":
                        return "celsius";
                }

                Console.WriteLine("You did not enter a recognised key.");
            }
        }

        public static double ConvertToTemperature(this double startingMeasurement, string desiredUnit, string startingUnit)
        {
            return startingUnit switch
            {
                "celsius" => (desiredUnit switch
                {
                    "kelvin" => (startingMeasurement + 273.15),
                    "fahrenheit" => ((startingMeasurement * 1.8) + 32),
                    _ => startingMeasurement
                }),
                "fahrenheit" => (desiredUnit switch
                {
                    "kelvin" => ((startingMeasurement + 459.67) * (5d / 9d)),
                    "celsius" => ((startingMeasurement - 32) / 1.8),
                    _ => startingMeasurement
                }),
                "kelvin" => (desiredUnit switch
                {
                    "celsius" => (startingMeasurement - 273.15),
                    "fahrenheit" => (startingMeasurement * (9d / 5d) - 459.67),
                    _ => startingMeasurement
                }),
                _ => startingMeasurement
            };
        }
    }

    public static class CurrencyConversions
    {
        public static void GetMoneyAndShowResult()
        {
            while (true)
            {
                Console.Write("Please enter an amount of money: ");

                if (double.TryParse(Console.ReadLine(), out var startingMeasurement))
                {
                    var startingUnit = GetStartingUnit();
                    var desiredUnit = GetDesiredUnit();

                    Console.WriteLine($"{startingMeasurement} {startingUnit.ToUpper()} is {startingMeasurement.ConvertToCurrency(desiredUnit, startingUnit)} {desiredUnit.ToUpper()}.");
                    return;
                }

                Console.WriteLine("You must enter a number for the money.");
            }
        }

        public static string GetStartingUnit()
        {
            while (true)
            {
                Console.Write("Please enter the acronym for the currency you want to convert from (e.g. GBP is Great Britain Pound): ");

                var startingUnit = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(startingUnit))
                {
                    switch (startingUnit.ToLower())
                    {
                        case "usd":
                            return "usd";
                        case "gbp":
                            return "gbp";
                        case "aud":
                            return "aud";
                    }
                }

                Console.WriteLine("You did not enter a recognised currency.");
            }
        }

        public static string GetDesiredUnit()
        {
            while (true)
            {
                Console.Write("Please enter the acronym for the currency you want to convert to: ");

                var desiredUnit = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(desiredUnit))
                {
                    switch (desiredUnit.ToLower())
                    {

                        case "usd":
                            return "usd";
                        case "gbp":
                            return "gbp";
                        case "aud":
                            return "aud";
                    }
                }

                Console.WriteLine("You did not enter a recognised key.");
            }
        }

        public static double ConvertToCurrency(this double startingMeasurement, string desiredUnit, string startingUnit)
        {
            return startingUnit switch
            {
                "usd" => (desiredUnit switch
                {
                    "gbp" => (startingMeasurement * 0.771688),
                    "aud" => (startingMeasurement * 1.52060),
                    _ => startingMeasurement
                }),
                "gbp" => (desiredUnit switch
                {
                    "usd" => (startingMeasurement * 1.29586),
                    "aud" => (startingMeasurement * 1.97035),
                    _ => startingMeasurement
                }),
                "aud" => (desiredUnit switch
                {
                    "usd" => (startingMeasurement * 0.657636),
                    "gbp" => (startingMeasurement * 0.507496),
                    _ => startingMeasurement
                }),
                _ => startingMeasurement
            };
        }
    }

    public static class VolumeConversions
    {
        public static void GetVolumeAndShowResult()
        {
            while (true)
            {
                Console.Write("Please enter a volume: ");

                if (double.TryParse(Console.ReadLine(), out var startingMeasurement))
                {
                    var startingUnit = GetStartingUnit();
                    var desiredUnit = GetDesiredUnit();

                    Console.WriteLine($"{startingMeasurement}{startingUnit[0].ToString().ToUpper()} is {startingMeasurement.ConvertToVolume(desiredUnit, startingUnit)}{desiredUnit[0].ToString().ToUpper()}.");
                    return;
                }

                Console.WriteLine("You must enter a number for the volume.");
            }
        }

        public static string GetStartingUnit()
        {
            while (true)
            {
                Console.Write("Please enter the measurement the volume is in (e.g. \"litre\"): ");

                var startingUnit = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(startingUnit))
                {
                    switch (startingUnit.ToLower())
                    {
                        case "litre":
                        case "liter":
                            return "litre";
                        case "pint":
                            return "pint";
                        case "millilitres":
                            return "millilitres";
                    }
                }

                Console.WriteLine("You did not enter a recognised currency.");
            }
        }

        public static string GetDesiredUnit()
        {
            while (true)
            {
                Console.Write("Please enter the unit you would like to convert that volume to: ");

                var startingUnit = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(startingUnit))
                {
                    switch (startingUnit.ToLower())
                    {
                        case "litre":
                        case "liter":
                            return "litre";
                        case "pint":
                            return "pint";
                        case "millilitres":
                            return "millilitres";
                    }
                }

                Console.WriteLine("You did not enter a recognised currency.");
            }
        }

        public static double ConvertToVolume(this double startingMeasurement, string desiredUnit, string startingUnit)
        {
            return startingUnit switch
            {
                "litre" => (desiredUnit switch
                {
                    "pint" => (startingMeasurement * 1.7598),
                    "millilitre" => (startingMeasurement / 1000),
                    _ => startingMeasurement
                }),
                "pint" => (desiredUnit switch
                {
                    "litre" => (startingMeasurement / 1.7598),
                    "millilitre" => (startingMeasurement / 0.0017598),
                    _ => startingMeasurement
                }),
                "millilitre" => (desiredUnit switch
                {
                    "litre" => (startingMeasurement * 1000),
                    "pint" => (startingMeasurement * 0.0017598),
                    _ => startingMeasurement
                }),
                _ => startingMeasurement
            };
        }
    }
}

