using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> Employee = new List<Employee>()
            {
            new Employee() { FirstName = "Jack", LastName = "Huffman", Id = 1 },
            new Employee() { FirstName = "Prince", LastName = "McKay", Id = 2 },
            new Employee() { FirstName = "Jenny", LastName = "Lord", Id = 3 },
            new Employee() { FirstName = "Joe", LastName = "Smith", Id = 4 },
            new Employee() { FirstName = "Buddy", LastName = "Maine", Id = 5 },
            new Employee() { FirstName = "Ronald", LastName = "Stewart", Id = 6 },
            new Employee() { FirstName = "Joe", LastName = "Miller", Id = 7 },
            new Employee() { FirstName = "Brett", LastName = "Rock", Id = 8 },
            new Employee() { FirstName = "Angelie", LastName = "Simpson", Id = 9 },
            new Employee() { FirstName = "Maria", LastName = "Rodriguez", Id = 10 }
            };

            List<Employee> People = new List<Employee>();
            foreach (Employee name in Employee)
                                               
            {
                if (name.FirstName == "Joe")
                {
                    People.Add(name);
                    Console.WriteLine("Names with " + name.FirstName + " using foreach loop");
                }
            }

            List<Employee> People2 = new List<Employee>();
            People2 = Employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in People2)
            {
                Console.WriteLine("Names " + person.FirstName + " Added to the List using lambda");
            }

            List<Employee> People3 = new List<Employee>();
            People3 = Employee.Where(x => (x.Id > 5)).ToList();
            foreach (Employee personId in People3)
            {
                Console.WriteLine(personId.Id);
            }
            Console.ReadLine();
        }
    }
}
