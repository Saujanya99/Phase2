using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest12
    {
        int countPositive = 0;
        int countNegative = 0;
        int countZero = 0;

        public void CalcCount(List<int> numList)
        {
            foreach (var item in numList)
            {
                if (item > 0)
                {
                    countPositive++;
                }
                else if (item < 0)
                {
                    countNegative++;
                }
                else
                {
                    countZero++;
                }

            }
            Console.WriteLine("The above input values has {0} Positive value(s), {1} Negative value(s) and {2} Zero value(s)", countPositive, countNegative, countZero);
        }
    }
    class Problem12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of inputs you want to give(N)");
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> numList = new List<int>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}.Enter a number ", i + 1);
                int num = Convert.ToInt32(Console.ReadLine());
                numList.Add(num);
            }
            ProblemTest12 p1 = null;
            p1 = new ProblemTest12();
            p1.CalcCount(numList);

        }

    }
}
