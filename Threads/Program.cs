using System;

namespace Threads
{
    class Program
    {
        public static int flag;

        static void Main(string[] args)
        {
            flag = 0;
            MyThread t1 = new MyThread("Поток 1");
            MyThread t2 = new MyThread("Поток 2");
            Console.Read();
        }
    }
}
