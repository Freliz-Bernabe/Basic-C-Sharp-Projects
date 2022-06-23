using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            Console.WriteLine("Please select an index of the array.");
            int indString = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if (indString > 4)
            {
                Console.WriteLine("Index doesn't exist.");
                Console.ReadLine();
            }

            Console.WriteLine(stringArray[indString]);
            Console.ReadLine();


            int[] numArray = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Please select an index of the array.");
            int indArray = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if (indArray > 5)
            {
                Console.WriteLine("Index doesn't exist.");
                Console.ReadLine();
            }

            Console.WriteLine(numArray[indArray]);
            Console.ReadLine();


            List<string> intList = new List<string>();
            intList.Add("Hi");
            intList.Add("Hello");
            intList.Add("How are you?");

            Console.WriteLine("Please select an index of the array.");
            int indList = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            if (indList > 2)
            {
                Console.WriteLine("Index doesn't exist.");
                Console.ReadLine();
            }

            Console.WriteLine(intList[indList]);
            Console.ReadLine();
        }
    }
}
