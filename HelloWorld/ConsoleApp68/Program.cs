using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string str = Console.ReadLine();
            string[] strarr = str.Split(',');
            int[] iArr = Array.ConvertAll(strarr, s => int.Parse(s));
            for (int i =0; i<iArr.Length; i++)
            {
                sum += iArr[i];

            }
            Console.WriteLine("합은={0}", sum);
        }
    }
}
