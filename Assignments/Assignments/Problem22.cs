using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class CommissionCal
    {
        double sales;
        double commission;

        public void Commission()
        {
            Console.WriteLine("Enter the monthly sales of salesman:");
            sales = Convert.ToInt32(Console.ReadLine());

            if (sales <= 10000 && sales > 0)
            {
                commission = 0;

            }

            else if (sales > 10000 && sales <= 30000)
            {
                commission = (sales * 0.25);
            }

            else if (sales > 30000 && sales <= 50000)
            {
                commission = (sales * 0.05);
            }

            else if (sales > 50000 && sales <= 80000)
            {
                commission = (sales * 0.75);
            }

            else if (sales > 80000)
            {
                commission = (sales * 0.1);
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Commission={0}", commission);
        }



    }
    class Problem22
    {
        static void Main(string[] args)
        {
            CommissionCal obj = new CommissionCal();
            obj.Commission();

        }
    }

}


