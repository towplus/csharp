using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public abstract class Dog
    {
        public string name { get; set; }
        public abstract void jitda();
        //{
        //    Console.WriteLine(name + "가 짖다.");
        //}
    }

    public class Pudle : Dog
    {
        public override void jitda()
        {Console.WriteLine(name + "푸들푸들.");}
        public void work() { Console.WriteLine(name + "가 일한다."); }
    }
    public class Jindo : Dog
    {
        public override void jitda() { Console.WriteLine(name + "진도진도."); }
        public void run() { Console.WriteLine(name + "가 달린다."); }
    }

    class DogManager
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle(); p.name = "푸들이"; p.jitda();p.work();
            Dog j = new Jindo(); j.name = "진돌이"; j.jitda();j.run();
        }
    }
}
