using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai7
{
    class Program
    {
        static void Main(string[] args)
        {
            IbaStack ibastack = new IbaStack(3);
            ibastack.Push("apple");
            ibastack.Push("banana");
            ibastack.Push("orange");

            Console.WriteLine(ibastack.Pop());
            Console.WriteLine(ibastack.Pop());
            Console.WriteLine(ibastack.Pop());
        }
    }
}
