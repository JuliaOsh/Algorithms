using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms
{
    class Algorithms
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose task or 0 to exit: ");
                Console.WriteLine("");

                var tasks = new ILesson[6];

                Lesson1PrimeNumberChecker isNumberPrime = new Lesson1PrimeNumberChecker();
                AlgorithmComplexity algorithmComplexity = new AlgorithmComplexity();
                Lesson1Fibonacci fibo = new Lesson1Fibonacci();
                Lesson2LinkedListPoC linkedList = new Lesson2LinkedListPoC();
                Lesson3PerformanceRatio performanceRatio = new Lesson3PerformanceRatio();
                Lesson4Tree btree = new Lesson4Tree();

                tasks[0] = isNumberPrime;
                tasks[1] = algorithmComplexity;
                tasks[2] = fibo;
                tasks[3] = linkedList;
                tasks[4] = performanceRatio;
                tasks[5] = btree;

                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine($"{tasks[i].LessonID} {tasks[i].LessonDescription}");
                }

                //TO DO rename output methods, reduce switching 
                string input = Console.ReadLine();
                if (input == "0")
                {
                    return;
                }
                bool demonstrationPerformed = false;
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (tasks[i].LessonID == input)
                    {
                        tasks[i].Demonstration();
                        demonstrationPerformed = true;
                    }
                }
                if (demonstrationPerformed == false)
                {
                    Console.WriteLine("This task number does not exist. Please try again");
                }                                                       
            }
        }
    }
}
