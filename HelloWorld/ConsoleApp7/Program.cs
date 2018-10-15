using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10; int j = 20; int a;
            a = i & j; i = i >> 3; j = i << 3;
            Console.WriteLine("a={0}, i={1}, j={2}", a, i, j);
            Console.ReadLine();
        }
    }
}
