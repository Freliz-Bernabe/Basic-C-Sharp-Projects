using System;

namespace Loop.DoWhile
{
    class Program
        {
            static void Main()
            {
                Console.WriteLine("Guess a number between 1 to 10?");
                int number = Convert.ToInt32(Console.ReadLine());
                bool isGuessed = number == 6;

                do
                {
                    switch (number)
                    {
                        case 5:
                            Console.WriteLine("You guessed 5. Try again.");
                            Console.WriteLine("Guess a number between 1 to 10?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("You guessed 2. Try again.");
                            Console.WriteLine("Guess a number between 1 to 10?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("You guessed 8. Try again.");
                            Console.WriteLine("Guess a number between 1 to 10?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("You guessed the number 6. That is correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number between 1 to 10?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!isGuessed);

                Console.Read();
            }
        }
    }
