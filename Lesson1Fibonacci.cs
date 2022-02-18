using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Lesson1Fibonacci : ILesson
    {
        public string LessonID { get; private set; }
        public string LessonDescription { get; set; }

        public Lesson1Fibonacci()
        {
            LessonID = "1.3";
            LessonDescription = "Calculation of Fibo number";
        }

        public static long FiboCycle(long N)
        {
            long zeroNumber = 0;
            long firstNumber = 1;

            if (N < 0)
            {
                //Console.WriteLine("This number is invalid");
                return -1;
            }
            else if (N == 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i <= N; i++)
                {
                    long fiboNumber = zeroNumber + firstNumber;
                    zeroNumber = firstNumber;
                    firstNumber = fiboNumber;
                }
                return firstNumber;
            }
        }

        public static long FiboRecursion(long N)
        {
            if (N < 0)
            {
                //Console.WriteLine("This number is invalid");
                return -1;
            }
            else if (N == 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 1;
            }
            else
            {
                return FiboRecursion(N - 2) + FiboRecursion(N - 1);
            }
        }

        public void Demonstration()
        {
            FiboTest TestCase1_3_1 = new FiboTest(0, null, 0);
            FiboTest TestCase1_3_2 = new FiboTest(1, null, 1);
            FiboTest TestCase1_3_3 = new FiboTest(610, null, 15);
            FiboTest TestCase1_3_4 = new FiboTest(-1, null, -1);
            FiboTest TestCase1_3_5 = new FiboTest(-1, null, -10);

            TestCase1_3_1.DoTest();
            TestCase1_3_2.DoTest();
            TestCase1_3_3.DoTest();
            TestCase1_3_4.DoTest();
            TestCase1_3_5.DoTest();
        }
    }
}
