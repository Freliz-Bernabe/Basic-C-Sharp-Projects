using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 10;
            int dog = 100;
            int cat = 7;

            MathOp FirstOp = new MathOp();
            FirstOp.MathMethodFirst(num1, num2);
            FirstOp.MathMethodSecond(dog, cat);

            Console.ReadLine();
        }
    }
}
