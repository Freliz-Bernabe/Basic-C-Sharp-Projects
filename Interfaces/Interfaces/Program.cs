﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employees(); 
            employee.Quit();

            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" }; 
            name.SayName(); 
            Console.ReadLine();
        }
    }
}
