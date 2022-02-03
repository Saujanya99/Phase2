using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{

    public class ProblemTest24
    {
        
        int hours;
        int totalWage;
        int wage40;
        int wage60;
        int wage90;

        public void Wage()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number of hours worked by employee {0}",i+1);
                hours = Convert.ToInt32(Console.ReadLine());


                if (hours <= 40 && hours > 0)
                {
                    wage40 = hours * 10;
                    wage60 = 0;
                    wage90 = 0;

                }

                else if (hours > 40 && hours <= 60)
                {
                    wage60 = (hours - 40) * 15;
                    wage40 = 400;
                    wage90 = 0;

                }

                else if (hours > 60)
                {
                    wage90 = (hours - 60) * 20;
                    wage40 = 400;
                    wage60 = 300;
                }

                else
                {
                    Console.WriteLine("Invalid input");

                }

                totalWage = wage40 + wage60 + wage90;


                Console.WriteLine($"Hours\t\tWages(10ph)\t\tWages(15ph)\t\tWages(20ph)\t\tTotalwages");
                Console.WriteLine($"{hours}\t\t\t{wage40}\t\t\t{wage60}\t\t\t{wage90}\t\t\t{totalWage}");

            }


        }

        class Problem24
        {
        
            //static void Main(string[] args)
            //{
            //    ProblemTest24 p1;
            //    p1=new ProblemTest24();
            //    p1.Wage();

            //}

        }

    }
}
