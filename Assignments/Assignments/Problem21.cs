using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Problem21
    {
        public class ProblemTest21
        {

            int femaleCount = 0;
            int maleCount = 0;
            float percF;
            float percM;
            string gender;
            string genderL;
            string status;
            string statusL;
            int num = 3;

            public void calcPerc()
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter gender:");
                    gender = Console.ReadLine();
                    Console.WriteLine("Enter status(Dropouts or Continued):");
                    status = Console.ReadLine();
                    genderL = gender.ToLower();
                    Console.WriteLine(genderL);
                    statusL = status.ToLower();
                    Console.WriteLine(statusL);

                    if (genderL == "male" && statusL == "dropout")
                    {
                        maleCount++;
                    }

                    if (genderL == "female" && statusL == "dropout")
                    {
                        femaleCount++;
                    }
                }
                Console.WriteLine(maleCount);
                Console.WriteLine(femaleCount);
                percF = (femaleCount * 100) / num;
                percM = (maleCount * 100) / num;


                Console.WriteLine("Percentage of Male dropouts: {0}%", percM);
                Console.WriteLine("Percentage of Female dropouts: {0}%", percF);
            }

            static void Main(string[] args)
            {
                ProblemTest21 p1;
                p1 = new ProblemTest21();
                p1.calcPerc();

            }

        }
    }
}
