using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sArr = s.Split(',');
            int[] arr = Array.ConvertAll(sArr, t => int.Parse(t));

            int[] bub = arr;
            for (int j = 0; j < bub.Length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (bub[j] < bub[i])
                    {
                        int tem = arr[j];
                        bub[j] = bub[i];
                        bub[i] = tem;
                    }
                }
            }
            for (int i = 0; i < bub.Length; i++)
            {
                Console.Write("{0},", bub[i]);
            }
            Console.WriteLine("\n------------------------");

            int[] sel = arr;
            for (int j = 0; j < sel.Length-1; j++)
            {
                int minindex = j;
                for (int i= j+1; i<sel.Length; i++)
                {
                    if (sel[j] > sel[i])
                    {
                        minindex = i;
                    }
                }
                int tem = sel[minindex];
                sel[minindex] = sel[j];
                sel[j] = tem;
            }
            for (int i = 0; i < sel.Length; i++)
            {
                Console.Write("{0},", sel[i]);
            }
        }
    }
}
