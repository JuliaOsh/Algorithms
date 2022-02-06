using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibo : ILesson
    {
        public string LessonID { get; set; }
        public string LessonDescription { get; set; }

        public Fibo(string lessonID, string lessonDescription)
        {
            LessonID = lessonID;
            LessonDescription = lessonDescription;
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
    }
}
