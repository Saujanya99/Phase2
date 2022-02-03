using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem18
    {
        static void Main(string[] args)
        {
            double smallestNum = 0;
            double largestNum = 0;
            double[] myArr = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}.Enter a positive number", i + 1);
                myArr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(myArr);
            smallestNum = myArr[0];
            Array.Reverse(myArr);
            largestNum = myArr[0];
            double range = largestNum - smallestNum;
            Console.WriteLine($"The smallest number is {smallestNum} and the largest number is {largestNum} with range={range}");

        }
    }
}
