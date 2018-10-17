using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Test<T>
    {
        
        public T Sum<T>(T i ,T j) {
            return  (dynamic) i + (dynamic) j;
        }

    }
    class TestMain
    {
        static void Main(string[] args)
        {
            Test<int> t = new Test<int>();
            int i = 1; int j = 2;
            Console.WriteLine("{0} + {1} = {2}", i, j, t.Sum(i, j)); ;
        }
    }
}
