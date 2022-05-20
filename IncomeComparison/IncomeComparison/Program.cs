using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("15");
            Console.WriteLine("Hours worked per week");
            Console.WriteLine("40");
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("20");
            Console.WriteLine("Hours worked per week");
            Console.WriteLine("40");
            Console.ReadLine();

            int hourlyratep1 = 15;
            int hoursworkedp1 = 40;
            int product1 = hourlyratep1 * hoursworkedp1 * 48;
            Console.WriteLine("Annual salary of Person 1");
            Console.WriteLine(product1);
            Console.ReadLine();

            int hourlyratep2 = 20;
            int hoursworkedp2 = 40;
            int product2 = hourlyratep2 * hoursworkedp2 * 48;
            Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine(product2);
            Console.ReadLine();

            int salaryPerson1 = (product1);
            int salaryPerson2 = (product2);
            bool makesMore = (product1 > product2);
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(makesMore);
            Console.ReadLine();

        }
    }
}
