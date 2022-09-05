using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation.mathOp(3, 4);
            MathOperation.mathOp(numberOne: 5, numberTwo: 32);
            Console.ReadLine();
        }
    }
}
