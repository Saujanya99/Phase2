using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem16
    {
        static void Main(string[] args)
        {
            double[] myArr = new double[100];
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}.Enter a positive number", i + 1);
                myArr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(myArr);
            Console.WriteLine("The smallest number is {0}", myArr[0]);

        }
    }
}
