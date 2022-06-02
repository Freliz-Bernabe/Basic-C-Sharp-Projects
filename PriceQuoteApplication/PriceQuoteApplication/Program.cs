using System;

namespace PriceQuoteApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

            int total = packageWidth + packageHeight + packageLength;

            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            int num1 = packageHeight;
            int num2 = packageWidth;
            int num3 = packageLength;
            int product = num1 * num2 * num3;
            int product2 = product * packageWeight;
            int quotient = product2 / 100;
            int result = quotient;
            string totalPrice = result.ToString();

            Console.WriteLine("Your estimated total for shipping this package is: $" + totalPrice);
            Console.ReadLine();

            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
