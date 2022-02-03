using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N");
            int num = Convert.ToInt32(Console.ReadLine());
            double[] myArr = new double[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}.Enter a positive number", i + 1);
                myArr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(myArr);
            Array.Reverse(myArr);
            Console.WriteLine("The largest number is {0}", myArr[0]);

        }
    }
}
