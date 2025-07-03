using System;

namespace YearToDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of years:");
            int years = 0;
            bool isConverted = int.TryParse(Console.ReadLine(), out years);

            if (isConverted && years >= 0)
            {
                int days = years * 365;
                int weeks = years * 52;
                int months = years * 12;
                int hours = days * 24;
                int prayers = days * 5;
                int rak3at = days * 17;
                int jum3at = weeks;

                Console.WriteLine("Number of months: " + months);
                Console.WriteLine("Number of weeks: " + weeks);
                Console.WriteLine("Number of days: " + days);
                Console.WriteLine("Number of hours: " + hours);
                Console.WriteLine("Number of prayers: " + prayers);
                Console.WriteLine("Number of rak3at: " + rak3at);
                Console.WriteLine("Number of jum3at (Fridays): " + jum3at);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of years.");
            }
        }
    }
}

