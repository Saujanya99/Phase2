using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class CalcSumAndProd
    {
        public void Calc()
        {
            int sum = 0;
            int prod = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}.Please enter a number",i+1);
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                prod = prod * num;
            }
            Console.WriteLine("The Sum of the input numbers is {0} ",sum);
            Console.WriteLine("The Product of the input numbers is {0} ", prod);

        }
    }
    class Problem9
    {
        static void Main(string[] args)
        {
            CalcSumAndProd c1 = null;
            c1 = new CalcSumAndProd();
            c1.Calc();
        }
    }
}
