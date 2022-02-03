using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    
    class Problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input order amount for Product A");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input order amount for Product B");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5000)
            {
                int discA = (5 * num1) / 100;
                Console.WriteLine("Discount on Product A is {0} ", discA);
            }
            else
            {
                Console.WriteLine("No discount on Product A");
            }
            if (num2 > 10000)
            {
                int discB = (7 * num2) / 100;
                Console.WriteLine("Discount on Product B is {0} ", discB);
            }
            else
            {
                Console.WriteLine("No discount on Product B");
            }
        }
    }
}
