using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int yearsOld = Convert.ToInt32(Console.ReadLine());
            bool yearsAge = (yearsOld > 15 && yearsOld >= 15);
            Console.WriteLine(yearsAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string hasDui = (Console.ReadLine());
            bool haveDui = false;
            Console.WriteLine(haveDui);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            bool noOfTickets = (howMany < 4 && howMany <= 4);
            Console.WriteLine(noOfTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool isQualified = (yearsOld > 15 && haveDui && howMany < 4);
            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}

