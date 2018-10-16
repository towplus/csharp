using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParamsTest
{
    static void Main()
    {
        ParamsTest p = new ParamsTest();
        Console.WriteLine(p.Sum(1, 2));
        Console.WriteLine(p.Sum(j:1, i:2));//명명된 인수
        Console.WriteLine(p.Sum(j:1));
        Console.WriteLine(p.Sum());
        //Console.WriteLine(p.Sum(1, 2, 3));
    }
    int Sum(int i=0, int j=0) //선택적 인수
    {
        Console.WriteLine("i={0}, j={1}", i, j);
        return i + j;
    }
    //int Sum(int i, int j, int k)
    //{
    //    return i + j + k;
    //}
    //int Sum(params int[] iArray)
    //{
    //    int sum = 0;
    //    foreach (int i in iArray) sum += i;
    //    return sum;
    //}
}