using System;
using System.Runtime.InteropServices;

namespace Threads
{
    class ClassFunc
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int InterlockedExchange(ref int Target, Int32 Value);
    }
}
