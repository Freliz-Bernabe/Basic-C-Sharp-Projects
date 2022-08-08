using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); 
            Employee<int> employeeId = new Employee<int>();
            employee.Things = new List<string>();
            employeeId.Things = new List<int>(); 

            employee.Things.Add("Fredelyn");
            employee.Things.Add("Frederick");
            employee.Things.Add("Ferdinand");
            employeeId.Things.Add(1); 
            employeeId.Things.Add(2);
            employeeId.Things.Add(3);

            foreach (string name in employee.Things) 
            {
                Console.WriteLine(name);
            }
            foreach (int Id in employeeId.Things)
            {
                Console.WriteLine(Id);
            }
            Console.ReadLine();
        }
    }
}
