using System;

class Program
{
    static void Main(string[] args)
    {
        // First required line
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for weight
        Console.WriteLine("Please enter the package weight:");
        float weight = float.Parse(Console.ReadLine());

        // If weight exceeds limit, exit program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // Prompt for width
        Console.WriteLine("Please enter the package width:");
        float width = float.Parse(Console.ReadLine());

        // Prompt for height
        Console.WriteLine("Please enter the package height:");
        float height = float.Parse(Console.ReadLine());

        // Prompt for length
        Console.WriteLine("Please enter the package length:");
        float length = float.Parse(Console.ReadLine());

        // Check if dimension total exceeds limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program
        }

        // Calculate quote: (Width * Height * Length * Weight) / 100
        float quote = (width * height * length * weight) / 100;

        // Display quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
