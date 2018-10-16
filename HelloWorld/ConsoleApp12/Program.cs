using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num=10;
            int sum = 0, i = 0;

            while (i++ <= num)
            {
                if (i % 2 == 0) sum += i;
            }
            Console.WriteLine("{0}까지 짝수의 합은 {1}", num, sum);

            string str = Console.ReadLine();
            num = int.Parse(str);


            sum = 0; i = 0;

            while (i++ < num)
            {
                 sum += i;
            }
            Console.WriteLine("{0}까지 합은 {1}", num, sum);

            


            int x = 0, y = 0;
            for (x = 1; x < 4; x++)
            {
                for (y = 2; y < 10; y++)
                {
                    int s = x * y;
                    Console.WriteLine("{0}x{1}={2}", x, y,s);
                }
            }

        }
    }
}
