using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample606
{
    class Program
    {
        delegate void Action(int a);

        static void Func1(int a)
        {
            Console.WriteLine($"a={a}");
        }
        static void Func2(int a)
        {
            Console.WriteLine($"a={a * 2}");
        }
        static void Func3(int a)
        {
            Console.WriteLine($"a={a * 3}");
        }
        static void Main(string[] args)
        {
            Action a = new Action(Func1);
            a += new Action(Func2);
            a += new Action(Func3);
            a(3);
        }
    }
}
