using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a={0},b={1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a={0},b={1}", a, b);
        }
    }
}
