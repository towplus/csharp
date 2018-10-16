using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j: 1, i: 2));
            SayHello(age: 20, name: "OJC");
        }
        static int Sum(int i, int j)
        {
            Console.WriteLine("i={0}, j={1}", i, j);
            return i + j;
        }
        static void SayHello(string name, int age)
        {
            Console.WriteLine("안녕, name = {0}, age = {1}", name, age);
        }
    }
}