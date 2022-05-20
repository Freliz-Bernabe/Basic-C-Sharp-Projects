using System;

namespace MathOperation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number to be multiplied by 50.");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int product = firstNum * 50;
            Console.WriteLine("The answer is " + product.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input a number to be added to 25.");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int total = secondNum + 25;
            Console.WriteLine("The answer is " + total.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input a number to be divided by 12.5.");
            double thirdNum = Convert.ToInt32(Console.ReadLine());
            double quotient = thirdNum / 12.5;
            Console.WriteLine("The answer is " + quotient.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input a number to check if it is greater than 50.");
            int fourthNum = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = fourthNum > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Please input a number to be divided by 7.");
            int fifthNum = Convert.ToInt32(Console.ReadLine());
            int remainder = fifthNum % 7;
            Console.WriteLine("The remainder is " + remainder.ToString());
            Console.ReadLine();
        }
    }
}
