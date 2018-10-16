using System;

namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;
            for ( int j=0;j<5;j++ )
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }
        }
    }
}