using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Delegate1
    {
        //private delegate int OnjSum(int i, int j);
        static void Main(string[] args)
        {
            //Delegate1 d = new Delegate1();
            //Action<int, int> myMethod = delegate (int i, int j)

            //Action<int, int> myMethod =  (int i, int j) => Console.WriteLine(i + j);

            Action<int, int> myMethod = ( i,  j) => Console.WriteLine(i + j);

            //{
            //    Console.WriteLine(i + j);
            //};
            //Func<int, int , int> myMethod = d.Sum;
            //Func<int, int , int> myMethod =new Func<int, int, int> (Delegate1.Sum);
            //OnjSum myMethod = new OnjSum(Delegate1.Sum);
            //OnjSum myMethod = Delegate1.Sum;
            myMethod(10, 30);
            //Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
        }
        
        //void Sum(int i, int j)
        //{
        //    Console.WriteLine(i + j);
        //}
        // int Sum(int i, int j) // static 을 빼면 위에서 객체를 만들어서 참조시켜야 한다.
        //static int Sum(int i, int j)
        //{
        //    return i + j;
        //}
    }
}
