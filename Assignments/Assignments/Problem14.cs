using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    public class ProblemTest14
    {
        public void StudentRes(int num)
        {
            double phyMarks = 0;
            double chemMarks = 0;
            double mathMarks = 0;
            double avgMarks = 0;
            double finalRes = 0;
            int firstCount = 0;
            int secondCount = 0;
            int passCount = 0;
            int failCount = 0;
            double[] marksArr = new double[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Physics marks for Student {0} out of 100", i + 1);
                phyMarks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Chemistry marks for Student {0} out of 100", i + 1);
                chemMarks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Maths marks for Student {0} out of 100", i + 1);
                mathMarks = Convert.ToInt32(Console.ReadLine());
                avgMarks = phyMarks + chemMarks + mathMarks;
                finalRes = avgMarks / 3;
                Console.WriteLine("Percentage of Student {0} is {1}%", i + 1, finalRes);
                marksArr[i] = finalRes;
                //finalRes = 0;
            }
            for (int i = 0; i < marksArr.Length; i++)
            {
                if (marksArr[i] >= 80)
                {
                    firstCount++;
                }
                else if (marksArr[i] >= 60 && marksArr[i] < 80)
                {
                    secondCount++;
                }
                else if (marksArr[i] >= 35 && marksArr[i] < 60)
                {
                    passCount++;
                }
                else
                {
                    failCount++;
                }
            }
            Console.WriteLine($"Out of {num} Student(s), {firstCount} Student(s) passed with First Class, {secondCount} Student(s) passed with Second Class, {passCount} Student(s) passed with Pass Class and {failCount} Student(s) Failed");
        }
    }
    class Problem14
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of students");
            int num = Convert.ToInt32(Console.ReadLine());
            ProblemTest14 p1 = new ProblemTest14();
            p1.StudentRes(num);

        }
    }
}
