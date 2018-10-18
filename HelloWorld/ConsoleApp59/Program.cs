using System;



namespace Akadia.NoDelegate

{
    delegate void Deli();
    public class MyClass

    {

        public void Process()

        {

            Console.WriteLine("Process() begin");

            Console.WriteLine("Process() end");

        }

    }



    public class Test

    {

        static void Main(string[] args)

        {

            MyClass myClass = new MyClass();

            Deli d0 = myClass.Process;
            d0();
            Action d1 = myClass.Process;
            d1();

        }

    }

}