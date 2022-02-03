using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem3
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 11; i <= 100; i++)
            {
                count++;
                Console.Write(i + " ");
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
