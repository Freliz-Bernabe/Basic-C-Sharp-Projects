using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            string text = "Here's the number you typed.";

            using (StreamWriter file = new StreamWriter(@"C:\Users\Freliz\Documents\Logs\log.txt", true)) 
            {
                file.WriteLine(number);
            }
        }
    }
}
