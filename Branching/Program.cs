using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the mandatory welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight exceeds the maximum allowed limit of 50
            if (weight > 50)
            {
                // Display error message and terminate the program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate the total sum of the dimensions to check size limits
            int dimensionsTotal = width + height + length;

            // Check if the total dimensions exceed the maximum allowed limit of 50
            if (dimensionsTotal > 50)
            {
                // Display error message and terminate the program if too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

            // Calculate the shipping quote: (Width * Height * Length * Weight) / 100
            // Using decimal or double ensuring precise currency calculations
            double product = width * height * length * weight;
            double quote = product / 100.0;

            // Display the final quote formatted as a dollar amount and say thank you
            // The :F2 format specifier ensures exactly two decimal places are shown
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
