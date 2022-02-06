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

                var tasks = new ILesson[3];


                IsNumberPrime isNumberPrime = new IsNumberPrime("1.1", "Defining if the number is prime or not");
                AlgorithmComplexity algorithmComplexity = new AlgorithmComplexity("1.2", "Approximate algorithm complexity");
                Fibo fibo = new Fibo("1.3", "Calculation of Fibo number");

                tasks[0] = isNumberPrime;
                tasks[1] = algorithmComplexity;
                tasks[2] = fibo;

                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine($"{tasks[i].LessonID} {tasks[i].LessonDescription}");
                }

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1.1":
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
                        break;

                    case "1.2":
                        AlgorithmComplexity.Description();
                        break;

                    case "1.3":
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
