using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
   
    class Problem20
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Students ");
            int num = Convert.ToInt32(Console.ReadLine());
            int roll = 0;
            string studName = "";
            int phyMarks = 0;
            int chemMarks = 0;
            int mathMarks = 0;
            double avgMarks = 0;


            List<int> rollNoArr = new List<int>();
            List<string> nameArr = new List<string>();
            List<double> avgArr = new List<double>();
            List<double> avgArr1 = new List<double>();
            string[] resultArr = new string[num];
            List<int> failArr = new List<int>();
            List<int> phyArr = new List<int>();
            List<int> chemArr = new List<int>();
            List<int> mathArr = new List<int>();
            List<int> phyArr1 = new List<int>();
            List<int> chemArr1 = new List<int>();
            List<int> mathArr1 = new List<int>();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the roll No. of Student {0}", i + 1);
                roll = Convert.ToInt32(Console.ReadLine());
                if (roll > 0)
                {
                    rollNoArr.Add(roll);
                    Console.WriteLine("Enter the name of Student {0}", i + 1);
                    studName = Console.ReadLine();
                    nameArr.Add(studName);
                    Console.WriteLine("Enter Physics marks of Student {0} out of 100", i + 1);
                    phyMarks = Convert.ToInt32(Console.ReadLine());
                    phyArr.Add(phyMarks);
                    Console.WriteLine("Enter Chemistry marks of Student {0} out of 100", i + 1);
                    chemMarks = Convert.ToInt32(Console.ReadLine());
                    chemArr.Add(chemMarks);
                    Console.WriteLine("Enter Maths marks of Student {0} out of 100", i + 1);
                    mathMarks = Convert.ToInt32(Console.ReadLine());
                    mathArr.Add(mathMarks);
                    avgMarks = (phyMarks + chemMarks + mathMarks) / 3;
                    avgArr.Add(avgMarks);
                    if (phyMarks < 35 | chemMarks < 35 | mathMarks < 35)
                    {
                        failArr.Add(i);
                    }
                    Console.WriteLine("=================================");
                }
                else
                {
                    Console.WriteLine("End of data");
                    break;
                }
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Mark list with Student Details");
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < num; i++)
            {
                if (avgArr[i] >= 75)
                {
                    resultArr[i] = "Distinction";

                }
                else if (avgArr[i] >= 60 && avgArr[i] < 75)
                {
                    resultArr[i] = "First Class";
                }
                else if (avgArr[i] >= 45 && avgArr[i] < 60)
                {
                    resultArr[i] = "Second Class";
                }
                else if (avgArr[i] >= 35 && avgArr[i] < 45)
                {
                    resultArr[i] = "Pass Class";
                }
                else
                {
                    resultArr[i] = "Fail";
                }


            }
            for (int i = 0; i < failArr.Count; i++)
            {

                resultArr[failArr[i]] = "Fail(less than 35 marks in one of the subject)";
            }

            Console.WriteLine("Student No.\t Roll no\t Name\t Percentage\t    Result ");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0,10} {1,10}\t     {2,10} {3,10}\t     {4,10}", i + 1, rollNoArr[i], nameArr[i], avgArr[i], resultArr[i]);

            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Highest marks in each subject and the Name of Student who gets it");
            Console.WriteLine("---------------------------------------");


            int[] newPhyArr = new int[num];
            phyArr.CopyTo(newPhyArr);

            int[] newChemArr = new int[num];
            chemArr.CopyTo(newChemArr);

            int[] newMathArr = new int[num];
            mathArr.CopyTo(newMathArr);

            phyArr.Sort();
            phyArr.Reverse();

            chemArr.Sort();
            chemArr.Reverse();

            mathArr1.Sort();
            mathArr1.Reverse();

            int phyHighest = phyArr[0];
            int chemHighest = chemArr[0];
            int mathHighest = mathArr[0];

            int pIndex = 0;
            for (int i = 0; i < newPhyArr.Length; i++)
            {
                if (newPhyArr[i] == phyHighest)
                {
                    pIndex = i;
                    break;
                }
            }
            

            int cIndex = 0;
            for (int i = 0; i < newChemArr.Length; i++)
            {
                if (newChemArr[i] == chemHighest)
                {
                    cIndex = i;
                    break;
                }
            }
            

            int mIndex = 0;
            for (int i = 0; i < newMathArr.Length; i++)
            {
                if (newMathArr[i] == mathHighest)
                {
                    mIndex = i;
                    break;
                }
            }
            



            Console.WriteLine("{0} scored the Highest marks in Physics-{1}", nameArr[pIndex], phyHighest);
            Console.WriteLine("{0} scored the Highest marks in Chemistry-{1}", nameArr[cIndex], chemHighest);
            Console.WriteLine("{0} scored the Highest marks in Math-{1}", nameArr[mIndex], mathHighest);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Highest Average ");
            Console.WriteLine("---------------------------------------");


            double[] newAvgArr = new double[num];
            avgArr.CopyTo(newAvgArr);
            avgArr.Sort();
            avgArr.Reverse();
            double avgHighest = avgArr[0];
            int avgIndex = 0;
            for (int i = 0; i < newAvgArr.Length; i++)
            {
                if (newAvgArr[i] == avgHighest)
                {
                    avgIndex = i;
                    break;
                }

            }


            Console.WriteLine("{0} scored the Highest Average-{1}", nameArr[avgIndex], avgHighest);

        }
    }
}
