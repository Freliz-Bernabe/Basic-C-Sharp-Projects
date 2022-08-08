using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person  
    {
        public string FirstName; 
        public string LastName; 
        public abstract void SayName();
    }

    public class Employees : Person
    {
        public override void SayName() 
        {
            Console.WriteLine(FirstName + " " + LastName); 
        }
    }
}