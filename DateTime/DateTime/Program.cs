using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string format = "MMMM d yyyy hh:mm tt";
            Console.WriteLine("Today's date and time is: ");
            Console.WriteLine(time.ToString(format));
            Console.WriteLine("Please enter a number: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The date and time after adding the number you entered is: ");
            Console.WriteLine(DateTime.Now.AddHours(hour)); 
            Console.ReadLine();
        }
    }
}
