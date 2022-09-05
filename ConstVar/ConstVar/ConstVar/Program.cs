using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string hiFrance = "Bonjour"; 
            Console.WriteLine(hiFrance);

            var user1 = new User("Miki", 800); 
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Phone);
            Console.Read();
        }
    }
}
