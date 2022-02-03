using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem23
    {


        static void Main(string[] args)
        {
            double monthlyBasicSalary;
            double calcDA = 0;
            double professionTax = 0;
            double incomeTax = 0;
            double grossIncome = 0;
            double netPayableSalary = 0;

            Console.WriteLine("Enter the monthly basic salary : ");
            monthlyBasicSalary = Convert.ToSingle(Console.ReadLine());

            #region DA CALCULATION
            if (monthlyBasicSalary <= 1000 && monthlyBasicSalary > 0)
            {
                calcDA = (monthlyBasicSalary * 60 / 100);
                if (calcDA < 300)
                {
                    calcDA = 300;
                }
            }
            else if (monthlyBasicSalary <= 2000 && monthlyBasicSalary > 0)
            {
                calcDA = ((monthlyBasicSalary - 1000) * 50 / 100) + 600;        //D.A Calculation
            }
            else if (monthlyBasicSalary > 2000 && monthlyBasicSalary > 0)
            {
                calcDA = ((monthlyBasicSalary - 2000) * 40 / 100) + 600 + 500;
                if (calcDA > 1500)
                {
                    calcDA = 1500;
                }
            }
            else
            {
                throw new Exception("Enter a valid non zero salary amount");
            }
            #endregion

            grossIncome = monthlyBasicSalary + calcDA;

            #region PROFESSION TAX CALCULATION
            if (grossIncome <= 800)
            {
                professionTax = 0;
            }
            else if (grossIncome>800 && grossIncome <= 1200)
            {
                professionTax = ((grossIncome * 15) / 100);                        //Profession tax Calculation
            }
            else if (grossIncome > 1200)
            {
                professionTax = ((grossIncome * 20) / 100);
            }
            #endregion

            double yearlyGrossIncome = grossIncome * 12;

            #region INCOME TAX CALCULATION

            if (yearlyGrossIncome <= 18000)
            {
                incomeTax = 0;
            }
            else if (yearlyGrossIncome <= 25000)
            {
                incomeTax = ((yearlyGrossIncome - 18000) * 25 / 100);
            }
            else if (yearlyGrossIncome <= 50000)
            {
                incomeTax = ((yearlyGrossIncome - 25000) * 30 / 100) + 1750;                    //income tax calculation
            }
            else if (yearlyGrossIncome <= 100000)
            {
                incomeTax = ((yearlyGrossIncome - 50000) * 40 / 100) + 9250;
            }
            else if (yearlyGrossIncome > 100000)
            {
                incomeTax = ((yearlyGrossIncome - 100000) * 50 / 100) + 29250;
            }
            #endregion

            netPayableSalary = yearlyGrossIncome - incomeTax - (professionTax * 12);

            #region OUTPUT
            Console.WriteLine("monthly D.A is {0} Rs", calcDA);
            Console.WriteLine("Yearly gross income is {0} Rs", yearlyGrossIncome);
            Console.WriteLine("Yearly income tax is {0} Rs", incomeTax);
            Console.WriteLine("Yearly profession tax is {0} Rs", (professionTax * 12));
            Console.WriteLine("=======================================");
            Console.WriteLine("Net payable salary per annum is {0} Rs", netPayableSalary);
            Console.ReadLine();
            #endregion
        }
    }
}
