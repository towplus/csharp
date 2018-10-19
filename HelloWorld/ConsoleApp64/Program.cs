using System;
using System.Threading;
namespace EvnetWaitHandleSample
{
    class Program
    {
        private static int count = 0;
        public static EventWaitHandle _waitHandle;
        static void Main(string[] args)
        {
            Console.Write("1:AutoResetEvent\n2:ManualResetEvent\n..................");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    //차단기 올라간 상태
                    _waitHandle = new AutoResetEvent(true);
                    break;
                case '2':
                    _waitHandle = new ManualResetEvent(true);
                    break;
            }
            Console.WriteLine("");
            Thread T1 = new Thread(new ThreadStart(DoWork));
            Thread T2 = new Thread(new ThreadStart(DoWork));
            T1.Start();
            T2.Start();
        }
        static private void DoWork()
        {
            _waitHandle.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(count++);
                Thread.Sleep(500);
            }
        }
    }
}
