using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class IsNumberPrime : ILesson
    {
        public string LessonID { get; set; }
        public string LessonDescription { get; set; }


        public IsNumberPrime(string lessonID, string lessonDescription)
        {
            LessonID = lessonID;
            LessonDescription = lessonDescription;
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
                else
                {
                    i++;
                }
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
    }
}
