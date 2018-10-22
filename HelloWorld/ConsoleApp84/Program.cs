using System;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            try
            {
                short b = checked((short)a);
                Console.WriteLine("정상");
            }
            catch (Exception e)
            {
                Console.WriteLine("예외 : {0}", e.StackTrace);
            }
        }
    }
}
