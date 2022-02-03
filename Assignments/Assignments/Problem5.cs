using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class TestProblem5
    {
        public static void PrimeOrNot(int num)
        {
            int flag = 0;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number", num);
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a prime number", num);
            }

        }
    }
    class Problem5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            TestProblem5.PrimeOrNot(num);
        }
    }
}
