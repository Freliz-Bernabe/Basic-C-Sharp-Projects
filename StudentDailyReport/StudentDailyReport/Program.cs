using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning College");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your course?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            string pageNumber = pageNum.ToString();
            Console.WriteLine("The page number is: " + pageNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool isNeeding = true;
            string needingStatus = Convert.ToString(isNeeding);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();
            Console.WriteLine("Your positive experiences are: " + yourExperiences);
            Console.ReadLine();

            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Your feedback is: " + yourFeedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hourStudied = Convert.ToInt32(hoursStudied);
            Console.WriteLine("You studied " + hoursStudied + " hours today.");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
