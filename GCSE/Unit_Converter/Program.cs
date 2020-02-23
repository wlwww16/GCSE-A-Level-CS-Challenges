using System;

namespace Unit_Converter
{
    public sealed class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Please enter a temperature: ");

                var startingMeasurement = double.Parse(Console.ReadLine());

                Console.Write("Is this measurement in kelvin, fahrenheit or celsius? ");

                var startingUnit = Console.ReadLine();

                Console.Write("Is your desired unit kelvin, fahrenheit or celsius? ");

                var desiredUnit = Console.ReadLine();

                Console.WriteLine($"{startingMeasurement}{startingUnit[0].ToString().ToUpper()} is {startingMeasurement.ConvertTo(desiredUnit, startingUnit)}{desiredUnit[0].ToString().ToUpper()}.");
            }
        }
    }

    public static class TemperatureConversions
    {
        public static double ConvertTo(this double startingMeasurement, string desiredUnit, string startingUnit)
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
}

