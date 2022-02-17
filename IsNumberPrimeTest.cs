using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IsNumberPrimeTest : ITest<bool>
    {
        public bool Expected { get; set; }
        public Exception ExpectedException { get; set; }
        public int Number { get; set; }

        public IsNumberPrimeTest(bool expected, Exception expectedException, int number)
        {
            Expected = expected;
            ExpectedException = expectedException;
            Number = number;
        }
        public void DoTest()
        {
            try
            {
                var actual = Lesson1PrimeNumberChecker.IsPrime(Number);

                if (actual == Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }     
    }
}
