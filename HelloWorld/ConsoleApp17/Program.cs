using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Triangle1
    {
        private int width;
        private int height;
        private int area;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Area
        {
            get
            {
                return width * height / 2;
            }
        }
    }

    class Triangle2
    {
        public int Width
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }
        public int Area
        {
            get
            {
                return Width * Height / 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle1 t1 = new Triangle1();
            t1.Width = 6;
        }
    }
}
