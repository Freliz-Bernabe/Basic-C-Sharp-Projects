using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        public class InputException : Exception  
        {                                       
            public InputException()
                : base() { }
            public InputException(string message)
            : base(message) { }
        }
        static void Main(string[] args)
        {
            int age; 
            try
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new InputException();
                }
                var today = DateTime.Now;

                var year = today.Year - age; 
                Console.WriteLine("You were born in " + year);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only an integer");
            }
            catch (InputException)
            {
                Console.WriteLine("You entered zero or a negative number. Please enter a number greater than 0.");
            }
            catch (Exception) 
            {
                Console.WriteLine("An Error occured. Please try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
