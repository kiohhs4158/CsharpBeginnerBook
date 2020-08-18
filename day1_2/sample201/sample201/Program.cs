using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample201
{
    class Program
    {
        static void Main(string[] args)
        {
            // 加算
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
            // 減算
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
            // 乗算
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
            // 除算
            Console.WriteLine("{0} / {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);
        }
    }
}
