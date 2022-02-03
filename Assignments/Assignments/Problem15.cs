using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest15
    {
        public void CalcYears(double popA, double popB, double rateA, double rateB)
        {
            int i = 1;
            int count = 0;
            while (popA < popB)
            {
                popA = popA + popA * (rateA / 100);
                popB = popB + popB * (rateB / 100);
                Console.WriteLine("{0}.Population of A = {1}", i, (int)popA);
                Console.WriteLine("{0}.Population of B = {1}", i, (int)popB);
                Console.WriteLine("--------------------------------------");
                i++;
                count++;
            }
            Console.WriteLine("It took {0} years for Population of A to exceed Population of B", count);
        }
    }
    class Problem15
    {
        static void Main(string[] args)
        {
            double popA = 60000000;
            double popB = 90000000;
            double rateA = 5.8;
            double rateB = 4.2;
            ProblemTest15 p1 = new ProblemTest15();
            p1.CalcYears(popA, popB, rateA, rateB);

        }
    }
}
