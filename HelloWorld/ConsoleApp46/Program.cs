﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp46
{
    class Test
    {
        [DllImport("User32.Dll")]
        public static extern int MessageBox(int h, string m, string c, int type);
        static void Main(string[] args)
        {
            MessageBox(0, "Hello!", "In C#", 0);
        }
    }
}
