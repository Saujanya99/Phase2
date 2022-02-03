using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class ProblemTest4
    {
        public void CalcWage(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the employee number");

                int empNo = Convert.ToInt32(Console.ReadLine());

                if (empNo > 0)
                {
                    Console.WriteLine("Enter the number of units for product 1 for employee number {0}", empNo);
                    double unit1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number of units for product 2 for employee number {0}", empNo);
                    double unit2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the number of units for product 3 for employee number {0}", empNo);
                    double unit3 = Convert.ToInt32(Console.ReadLine());

                    double wage = unit1 * 1.20 + unit2 * 1.80 + unit3 * 2.25;
                    Console.WriteLine("The gross wage of employee number {0} is {1}", empNo, wage);
                    Console.WriteLine("====================================================");
                }
                else
                {
                    Console.WriteLine("End of data");

                }
            }
        }
        class Problem4
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of employees");

                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------");
                ProblemTest4 p1 = new ProblemTest4();
                p1.CalcWage(num);

            }
        }
    }
}


