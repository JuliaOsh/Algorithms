using System;

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

                var tasks = new ILesson[4];

                Lesson1PrimeNumberChecker isNumberPrime = new Lesson1PrimeNumberChecker();
                AlgorithmComplexity algorithmComplexity = new AlgorithmComplexity();
                Lesson1Fibonacci fibo = new Lesson1Fibonacci();
                Lesson2LinkedListPoC linkedList = new Lesson2LinkedListPoC();

                tasks[0] = isNumberPrime;
                tasks[1] = algorithmComplexity;
                tasks[2] = fibo;
                tasks[3] = linkedList;

                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine($"{tasks[i].LessonID} {tasks[i].LessonDescription}");
                }

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1.1":
                        Lesson1PrimeNumberChecker.TestCases();
                        break;

                    case "1.2":
                        AlgorithmComplexity.Description();
                        break;

                    case "1.3":
                        Lesson1Fibonacci.TestCases();
                        break;

                    case "2.1":
                        Lesson2LinkedListPoC.Demonstration();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("This task number does not exist. Please try again");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
