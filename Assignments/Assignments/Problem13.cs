using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem13
    {
        static void Main(string[] args)
        {
            int countPass = 0;
            int countFail = 0;
            int marks = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Enter the marks for student number {0}", i + 1);
                marks = Convert.ToInt32(Console.ReadLine());
                if (marks < 35)
                {
                    countFail++;

                }
                else
                {
                    countPass++;
                }
            }
            Console.WriteLine("Out of 100 students, {0} Passed and {1} Failed", countPass, countFail);
        }
    }
}
