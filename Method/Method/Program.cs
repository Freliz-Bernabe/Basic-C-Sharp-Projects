using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            methods math = new methods();
            Console.WriteLine("Please enter a number to do some math operations with: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number you entered plus 5 = " + math.mathOperation1(input)); 
            Console.WriteLine("The number you entered minus 5 = " + math.mathOperation2(input)); 
            Console.WriteLine("The number you entered times 5 = " + math.mathOperation3(input));
            Console.ReadLine();
        }
    }
}
