namespace ShapeUser
{
    using System;

    using Shapes;

    public class ShapeUser
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            Console.WriteLine("Area={0}", c.Area());
        }
    }
}

  
