using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest1
    {
        public static int SumOfSquare(int num1, int num2)
        {
            return num1 * num1 + num2 * num2;
        }
    }
    class Problem1
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int numResult = ProblemTest1.SumOfSquare(num1, num2);
            if (numResult > 100)
            {
                Console.WriteLine("The two numbers are {0} and {1} ", num1, num2);
            }
            else
            {
                Console.WriteLine("The sum of their square is {0} ", numResult);
            }
            Console.ReadLine();
        }
    }
}
