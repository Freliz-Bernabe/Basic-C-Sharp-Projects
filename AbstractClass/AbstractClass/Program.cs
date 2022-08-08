using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" }; 
            name.SayName(); 
            Console.ReadLine();
        }
    }
}
