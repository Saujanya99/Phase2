using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem10
    {
        static void Main(string[] args)
        {

            int custNo;
            int prodNo;
            int qty;
            int rate;
            int totalSales;


            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Enter customer number:");
                custNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product number:");
                prodNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter quantity:");
                qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter rate:");
                rate = Convert.ToInt32(Console.ReadLine());
                totalSales = qty * rate;

                Console.WriteLine("Customer number\t Product number\tQuantity\tRate\t       Total Sales");
                Console.WriteLine("{0,10} {1,10}\t     {2,10} {3,10}\t      {4,10}", custNo, prodNo, qty, rate, totalSales);
                Console.WriteLine("======================================================================");
            }
        }
    }
}
