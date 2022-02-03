using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class GrossSalCal
    {
        int hours;
        string name;

        double grossSalary;
        int incentiveCount = 0;
        double incentive;
        double totalGrossSalary;
        double finalGross;
        double finalIncentive;

        public void Input()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Employee name");
                name = Console.ReadLine();
                Console.WriteLine("Enter hours worked by employee");
                hours = Convert.ToInt32(Console.ReadLine());

                grossSalary = hours * 4.50;
                if (grossSalary > 720)
                {
                    incentive = (grossSalary * 0.05);
                    incentiveCount++;

                }
                finalIncentive = finalIncentive + incentive;
                totalGrossSalary = grossSalary + incentive;
                finalGross = finalGross + totalGrossSalary;
                ShowDetails();

            }


        }


        public void ShowDetails()
        {
            Console.WriteLine("\tName\t   Hours Worked\t    Gross Salary\t   Incentive");
            Console.WriteLine("    {0,10}    {1,10}   {2,10}         {3,10}", name, hours, grossSalary, incentive);
            

        }
        public void Final()
        {
            Console.WriteLine("Total Incentive paid to 10 Employees={0}, Total Gross Salary paid to 10 Employees={1} and Out of 10 Employees,{2} got an incentive ", finalIncentive, totalGrossSalary, incentiveCount);
        }
    }
    class Problem11
    {
        public class Problem_11
        {
            static void Main(string[] args)
            {
                GrossSalCal cal = new GrossSalCal();
                cal.Input();
                cal.Final();

            }
        }


    }
}
