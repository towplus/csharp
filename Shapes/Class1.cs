﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(int r)
        {
            this.radius = r;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }

    }
}
