using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class FiboTest : ITest<long>
    {
        public long Expected { get; set; }
        public Exception ExpectedException { get; set; }

		long Number { get; set; }

		public FiboTest(long expected, Exception expectedException, long number)
		{
			Expected = expected;
			ExpectedException = expectedException;
			Number = number;
		}

		public void DoTest()
        {
			try
			{
				var actual = Fibo.FiboCycle(Number);

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
			try
			{
				var actual = Fibo.FiboRecursion(Number);

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
