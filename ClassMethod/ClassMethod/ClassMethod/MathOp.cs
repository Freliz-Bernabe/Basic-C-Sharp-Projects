using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassMethod
{
    public class MathOp
    {
        public void MathMethodFirst(int num1, int num2)
        {
            int result = num1 / 2;
            int result2 = num2 / 2;
            Console.WriteLine("Your number divided by 2 = " + result2);

        }

        public void MathMethodSecond(int num3, int num4)
        {
            int result5 = num3 * num4;
            Console.WriteLine(num3 + " x " + num4 + " = " + result5);
        }

        public static int MathMethodSecond(int num1, out int num2)
        {
            num2 = num1 + 5;
            return num2;

        }
    }
}