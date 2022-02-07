using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Lesson1PrimeNumberChecker : ILesson
    {
        public string LessonID { get; set; }
        public string LessonDescription { get; set; }


        public Lesson1PrimeNumberChecker()
        {
            LessonID = "1.1";
            LessonDescription = "Defining if the number is prime or not";
        }

        public static bool IsPrime(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                i++;
            }

            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void TestCases()
        {
            IsNumberPrimeTest TestCase1_1_1 = new IsNumberPrimeTest(true, null, 5);
            IsNumberPrimeTest TestCase1_1_2 = new IsNumberPrimeTest(true, null, 13);
            IsNumberPrimeTest TestCase1_1_3 = new IsNumberPrimeTest(true, null, 37);
            IsNumberPrimeTest TestCase1_1_4 = new IsNumberPrimeTest(false, null, 4);
            IsNumberPrimeTest TestCase1_1_5 = new IsNumberPrimeTest(false, null, 9);
            IsNumberPrimeTest TestCase1_1_6 = new IsNumberPrimeTest(false, null, 12);
            TestCase1_1_1.DoTest();
            TestCase1_1_2.DoTest();
            TestCase1_1_3.DoTest();
            TestCase1_1_4.DoTest();
            TestCase1_1_5.DoTest();
            TestCase1_1_6.DoTest();
        }
    }
}
