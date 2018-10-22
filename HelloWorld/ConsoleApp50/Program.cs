using System;
class Program
{
    public delegate void MyDelegate(int i, int j);
    public static void Main()
    {
        Console.WriteLine("Type Two numbers with comma seperator:");
        string str = Console.ReadLine();
        str.Trim();
        string[] strarr = str.Split(',');
        int first, second;
        first = int.Parse(strarr[0]);
        second = int.Parse(strarr[1]);
        MyDelegate CallBack = new MyDelegate(Program.Add);
        CallBack += new MyDelegate(Program.Minus);
        CallBack += new MyDelegate(Program.Multi);
        CallBack += new MyDelegate(Divide);
        CallBack(first, second);
    }

    public static void Add(int i, int j)
    {
        Console.WriteLine("{0}", i + j);
    }
    public static void Minus(int i, int j)
    {
        Console.WriteLine("{0}", i - j);
    }
    public static void Multi(int i, int j)
    {
        Console.WriteLine("{0}", i * j);
    }
    public static void Divide(int i, int j)
    {
        Console.WriteLine("{0}", (float) i / j);
    }
}