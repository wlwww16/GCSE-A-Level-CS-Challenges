using System;

namespace Speed_Tracker
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("At what time did the car go past the first camera? Format it as HH:MM:SS, e.g. 13:50:27 would be 50 minutes and 27 seconds past 1 in the afternoon.");

            var timeAtFirstCamera = TryFormatTime(Console.ReadLine());

            if (timeAtFirstCamera == null)
            {
                Console.WriteLine("Please format the date in HH:MM:SS.");
                Quit();
            }

            Console.WriteLine("At what time did the car go past the second camera? Format it as before.");

            var timeAtSecondCamera = TryFormatTime(Console.ReadLine());

            if (timeAtSecondCamera == null)
            {
                Console.WriteLine("Please format the date in HH:MM:SS.");
                Quit();
            }

            var difference = timeAtSecondCamera - timeAtFirstCamera;

            if (difference.Value.TotalSeconds <= 0) // Check if the difference is a negative number.
            {
                Console.WriteLine("The second time was less than or identical to the first.");
                Quit();
            }

            var distanceBetweenCameras = 1; // The spec. says the distance is 1 mile.
            var speed = distanceBetweenCameras / difference.Value.TotalHours; // speed = distance / time (you're welcome for the Physics tip).

            Console.WriteLine($"The speed of the car is {String.Format("{0:0.00}", speed)}mph."); // This would take a result, such as 123.4567, and cut off all but the first 2 decimals, thus 123.45.
        }

        public static DateTime? TryFormatTime(string time)
        {
            var splittedTime = time.Split(":");

            if (splittedTime.Length != 3) return null; // This check is a catch all for no numbers, only one, only two or more than three (all incorrect).
            

            if (int.TryParse(splittedTime[0], out var hours) == false || int.TryParse(splittedTime[1], out var minutes) == false || int.TryParse(splittedTime[2], out var seconds) == false)
            {
                // The line above tries to parse all numbers to integers (check if there are only numbers) and output variables appropriately. If any of them are false, meaning they contain text and not numbers, return null.
                return null;
            }

            if (hours < 0 || minutes < 0 || seconds < 0) return null; // Check none of the numbers are negative.

            return new DateTime().AddHours(hours).AddMinutes(minutes).AddSeconds(seconds); // If all is successful, construct a new DateTime object and add the appropriate time. The date is not needed so it does not need to be modified.
        }

        public static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
