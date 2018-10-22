﻿using System;
using System.Threading;

namespace ConsoleApp63
{
    class Program
    {
        public static Thread sleeperThread;

        static void Main(string[] args)
        {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }
        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper :" + i++ + "]");
                if(i==9)
                {
                    try
                    {
                        Console.WriteLine("i가 9 가 되어 1초쉼...");
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException ...");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
