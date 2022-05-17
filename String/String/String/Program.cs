using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main()
        {
            string name = "Michelle";
            string quote = "Hi Michelle! \nHow are you? \nWhat can i do for you?";

            Console.WriteLine(quote);
            Console.ReadLine();

            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Programming is a skill");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.AppendLine("best acquired by practice");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.AppendLine("and example rather than from books.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }

}