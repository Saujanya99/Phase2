using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest8
    {
        public void SumOfPow(double num)
        {
            double sum = 0;
            for (double i = 1; i <= num; i++)
            {

                sum = sum + Math.Pow(i, i + 1);

            }
            Console.WriteLine("The result is {0} ", sum);
        }
    }
    class Problem8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            double num = Convert.ToInt64(Console.ReadLine());
            ProblemTest8 p1 = null;
            p1 = new ProblemTest8();
            p1.SumOfPow(num);
        }
    }
}
