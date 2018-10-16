using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력하라:");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int mok = num;
            string na = "";
            while (mok > 0)
            {
                
                na = (mok % 2) + na;
                mok = mok / 2;
            }
            Console.WriteLine("{0}", na);

            Console.WriteLine("입력하라:");
            str = Console.ReadLine();
            num = int.Parse(str);
            mok = num;
            na = "";
            for (mok=num;mok>0;mok=mok/2)
            {
                na = (mok % 2) + na;               
            }
            Console.WriteLine("{0}", na);
        }
    }
}
