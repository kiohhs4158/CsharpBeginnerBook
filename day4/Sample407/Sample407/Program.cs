using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample407
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] a = new String[10000];
            for (int i = 0; i < 10000; i++)
            {
                a[i] = new String('K', 10000);
            }
            Console.WriteLine("メモリ使用量（GC発動前）：" + GC.GetTotalMemory(false));
            // aの参照を開放
            a = null;
            Console.WriteLine("メモリ使用量（参照解放後）：" + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量（GC発動後）：" + GC.GetTotalMemory(false));
        }
    }
}
