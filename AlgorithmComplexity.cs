using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class AlgorithmComplexity : ILesson
    {
        public string LessonID { get; set; }
        public string LessonDescription { get; set; }

        public AlgorithmComplexity(string lessonID, string lessonDescription)
        {
            LessonID = lessonID;
            LessonDescription = lessonDescription;
        }

        public static void Description()
        {
            Console.WriteLine("As we clearly see - there are 3 nested loops in this Algorithm.\n" +
                "Since all of the operations under innermost loop are O(1) - we can proceed with O(N^3) conclusion.");
        }
    }
}
