using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Enter first number:");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");

            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of " + x + " and " + y + " is " + (x + y));

        }
    }
}
