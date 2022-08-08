using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is it today?");
                string today = Console.ReadLine().ToLower(); 
                Day inputDay = (Day)Enum.Parse(typeof(Day), today);
                if (Enum.TryParse(today, out Day dayResult))
                {
                    Console.WriteLine("Today is " + dayResult);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
