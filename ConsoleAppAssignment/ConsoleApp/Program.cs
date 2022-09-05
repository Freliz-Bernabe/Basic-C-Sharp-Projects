using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            /* CONSOLE APP ASSIGNMENT PART 1 */

            Console.WriteLine("Please input some text.");
            string carString = Console.ReadLine();
            Console.ReadLine();

            string[] cars = { "Volvo", "Nissan", "Toyota", "Tesla", "Mercedes" };

            for (int c = 0; c < cars.Length; c++)
            {
                Console.WriteLine(cars[c] + carString);
            }
            Console.ReadLine();

            for (int c = 0; c < cars.Length; c++)
            {
                Console.WriteLine(cars[c]);
            }
            Console.ReadLine();

            /* CONSOLE APP ASSIGNMENT PART 2 */

            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("infinite loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 
            }

            /* CONSOLE APP ASSIGNMENT PART 3 */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Fix loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 until 5
            }


            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("The program has reached the < operator " + j);
                j++;
            }

            
            int x = 0;
            while (x <= 5)
            {
                Console.WriteLine("The program has reached the <= operator " + x);
                x++;
            }

            List<string> sweets = new List<string>() { "crunch", "skittles", "butterfingers", "oreo", "starburst" };
            Console.WriteLine("Enter a word to search.");
            string input = Console.ReadLine();
            bool records = false;

            foreach (string i in sweets)
            {

                if (input == i)
                {
                    Console.WriteLine("You got an index of: " + sweets.IndexOf(i));
                    records = true;
                    break; //stops code from executing once match is found (implemented "break" for EX. 8 even though "true" will stop the code from running when correct value is entered.)
                }
            }
            if (!records) //if text doesn't exist this wil print to screen EX. 7
            {
                Console.WriteLine("Your text doesn't exist in the list sweets.");
            }
            List<string> sweets1 = new List<string>() { "crunch", "crunch", "skittles", "skittles", "butterfingers", "butterfingers", "oreo", "oreo", "starburst", "starburst", "hello" };
            Console.WriteLine("Enter a word to search.");
            string input1 = Console.ReadLine();
            bool records1 = false;

            for (int k = 0; k < 10; k++)
            {
                if (sweets1[k] == input1)
                {
                    Console.WriteLine("Your item has an index of: " + k);
                    records1 = true;
                }
            }
            if (!records1) 
            {
                Console.WriteLine("Your text doesn't exist in the list sweets.");
            }

            List<string> storage = new List<string>();

            foreach (string y in sweets1)
            {

                if (storage.Contains(y))
                {
                    Console.WriteLine("This item already appears in the list: ");
                    Console.WriteLine(y);
                }
                else
                {
                    storage.Add(y);
                }
            }
            Console.ReadLine();
        }


    }
}
