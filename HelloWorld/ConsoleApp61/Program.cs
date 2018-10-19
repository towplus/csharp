using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp61
{
    public class ThreadTest
    {
        public void FirstWork()
        {
            for(int i=0; i< 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0}",i);
            }
        }
        public void SecondWork()
        {
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("S{0}", i);
            }
        }
        [MTAThread]
        public static void Main()
        {
            ThreadTest t = new ThreadTest();
            Thread first = new Thread(t.FirstWork);
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.Highest;

            first.Start();
            second.Start();
        }
    }
    
}
