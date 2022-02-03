using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class SumOfN
    {
        public void CalSum(double num)
        {
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("The Sum of starting {0} numbers is {1} ", num, sum);
        }
    }
    public class ProdOfN
    {
        public void CalProd(double num)
        {
            double prod = 1;
            for (int i = 1; i <= num; i++)
            {
                prod = prod * i;

            }
            Console.WriteLine("The Product of starting {0} numbers is {1} ", num, prod);
        }
    }
    class Problem6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double num = Convert.ToInt64(Console.ReadLine());
            SumOfN s1 = null;
            s1 = new SumOfN();
            s1.CalSum(num);

            ProdOfN p1 = null;
            p1 = new ProdOfN();
            p1.CalProd(num);

        }


    }
}
