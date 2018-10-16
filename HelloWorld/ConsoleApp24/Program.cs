using System;

namespace Bubble
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 1, 3, 5 };
            Console.WriteLine("{0}", arr[0]);
            Console.WriteLine("{0}", arr[1]);
            Console.WriteLine("{0}", arr[2]);
            Console.WriteLine("{0}", arr[3]);
            Console.WriteLine("{0}", arr.Length);

            for (int i = 0;i<arr.Length-1;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(arr[i] < arr[j])
                    {
                        int tem = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tem;
                    }
                }
            }
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write("{0},", arr[i]);
            }
        }
    }
}