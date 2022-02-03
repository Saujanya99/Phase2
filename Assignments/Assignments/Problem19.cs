using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignments
{
    class Problem19
    {
        static void Main(string[] args)
        {
            List<int> salesmanNumber = new List<int>();
            List<int> weeklySales = new List<int>();
            int minPointer = 0;
            int maxPointer = 0;
            Console.WriteLine("Enter the number of salesman");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter the salesman number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0) { break; }
                salesmanNumber.Add(num);


                Console.WriteLine("Enter his weeekly sales in Rs");
                int sales = Convert.ToInt32(Console.ReadLine());
                weeklySales.Add(sales);
            }
            int maxSales = weeklySales.Max();
            int minSales = weeklySales.Min();

            for (int i = 0; i < weeklySales.Count; i++)
            {
                if (weeklySales[i] == maxSales)
                {
                    maxPointer = i;
                }
                if (weeklySales[i] == minSales)
                {
                    minPointer = i;
                }

            }

            Console.WriteLine("The salesman number {0} has the lowest weekly salary of {1} Rs and the salesman number {2} has the highest weekly salary of {3} Rs", salesmanNumber[minPointer], minSales, salesmanNumber[maxPointer], maxSales);

        }
    }
}
