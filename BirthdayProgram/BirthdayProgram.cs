using System;
using System.Globalization;

namespace BirthdateValidator
{
    public class Program
    {
        /// <summary>
        /// The main entry point of the application. Prompts the user for their birthdate,
        /// validates the input, calculates age, and displays appropriate messages.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthdate (YYYY/MM/DD):");
            string? input = Console.ReadLine();

            // Check if input is null or empty
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: No input provided. Please enter your birthdate in the format YYYY/MM/DD.");
                return;
            }

            // Validate the input format
            if (!DateTime.TryParseExact(input.Trim(), "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                Console.WriteLine("Error: Invalid date format. Please use YYYY/MM/DD.");
                return;
            }

            DateTime today = DateTime.Today;

            // Check if the birthdate is in the future
            if (birthDate > today)
            {
                Console.WriteLine("You are not born yet but you know how to program!");
                return;
            }

            // Check if the birthdate is today
            if (birthDate == today)
            {
                Console.WriteLine("Are you sure you are born today?");
                return;
            }

            // Calculate and display age
            int age = CalculateAge(birthDate, today);
            Console.WriteLine($"You are {age} years old.");

            // Display custom message if age is 100 or more
            if (age >= 100)
            {
                Console.WriteLine("Wow! You are 100 or more years old!");
            }

            // Display birthday greeting if today is the user's birthday
            if (birthDate.Month == today.Month && birthDate.Day == today.Day)
            {
                Console.WriteLine("Happy Birthday!");
            }
        }

        /// <summary>
        /// Calculates the age based on the birthdate and the current date.
        /// </summary>
        /// <param name="birthDate">The user's birthdate.</param>
        /// <param name="today">The current date.</param>
        /// <returns>The calculated age.</returns>
        public static int CalculateAge(DateTime birthDate, DateTime today)
        {
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }
    }
}
