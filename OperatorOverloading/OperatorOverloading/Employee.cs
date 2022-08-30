using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Employee
    {
        public int Id { get; set; }

        public static bool operator ==(Employee person1, Employee person2) 
        {
            if (person1==person2)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee person1, Employee person2)
        {
            if (person1!=person2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}