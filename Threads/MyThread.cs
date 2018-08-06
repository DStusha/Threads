using System;
using System.Threading;

namespace Threads
{
    class MyThread
    {
        Thread thread;

        public MyThread(string name) 
        {
            thread = new Thread(func);
            thread.Name = name;
            thread.Start();
        }

        void func()
        {
            while (ClassFunc.InterlockedExchange(ref Program.flag, 1) == 1) Thread.Sleep(0);
            Console.WriteLine("Start" +" "+ Thread.CurrentThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("Stop" + " " + Thread.CurrentThread.Name);
            Program.flag = 0;
        }
    }
}
  