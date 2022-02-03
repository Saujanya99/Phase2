using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest25
    {
        int accno;
        string name;
        double deposit;
        int years;
        double maturity;


        public void calcMaturity()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter account number:");
                accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter deposit amount:");
                deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of years:");
                years = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Compute();

                Console.WriteLine($"Account number: {accno}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Deposit: {deposit}");
                Console.WriteLine($"Years: {years}");
                Console.WriteLine($"Maturity: {maturity}");
                Console.WriteLine("============================");
            }

        }

        public void Compute()
        {
            if (deposit >= 5000 && years >= 3)
            {
                maturity = deposit + (deposit * 0.12 * years);
            }

            else if (deposit >= 5000 && years < 3)
            {
                maturity = deposit + (deposit * 0.1 * years);
            }

            else if (deposit < 5000 && deposit > 0)
            {
                maturity = deposit + (deposit * 0.09 * years);
            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }


    }
    class Problem25
    {
        //static void Main(string[] args)
        //{
        //    ProblemTest25 p1 = new ProblemTest25();
        //    p1.calcMaturity();
            
        //}
    }

   
}
