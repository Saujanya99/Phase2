using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class Factorial
    {
        public void CalcFactorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of the number {0} is {1} ", num, fact);
        }

    }
    class Problem7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Factorial f1 = null;
            f1 = new Factorial();
            f1.CalcFactorial(num);

        }
    }
}
