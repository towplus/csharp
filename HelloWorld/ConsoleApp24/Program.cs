using System;

namespace Bubble
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            //int[] arr = { 2, 1, 3, 5 };
            //Console.WriteLine("{0}", arr[0]);
            //Console.WriteLine("{0}", arr[1]);
            //Console.WriteLine("{0}", arr[2]);
            //Console.WriteLine("{0}", arr[3]);
            //Console.WriteLine("{0}", arr.Length);
            string s = Console.ReadLine();
            string[] sArr = s.Split(',');
            int[] arr = Array.ConvertAll(sArr, t => int.Parse(t));

            for (int j = 0 ; j<arr.Length ; j++)
            {
                for(int i=0 ; i<j ; i++)
                {
                    if(arr[j] < arr[i])
                    {
                        int tem = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tem;
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