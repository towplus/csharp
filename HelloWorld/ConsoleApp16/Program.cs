using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Emp
{
    //private string name;
    //internal string name;
    public string Name // 자동구현속성
    {
        get;

        set;
        
    }

    //public void SetName(string name)
    //{
    //    this.name = name;
    //}
    //public string GetName()
    //{
    //    return this.name;
    //}
}

class EmpTest
{
    static void Main()
    {
        Emp e = new Emp();
        e.Name="홍길동";
        Console.WriteLine(e.Name);
    }
}