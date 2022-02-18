using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    interface ITest<T>
    {
        T Expected { get; set; }
        Exception ExpectedException { get; set; }

        public void DoTest();        
    }
}
