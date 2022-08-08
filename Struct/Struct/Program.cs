using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct Number 
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number price; 
            price.Amount = 66.8m; 
            Console.WriteLine(price.Amount);
            Console.ReadLine();
        }
    }
}