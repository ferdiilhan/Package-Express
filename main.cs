using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

    
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }


            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());


            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            decimal quote = (width * height * length * weight) / 100;

            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}