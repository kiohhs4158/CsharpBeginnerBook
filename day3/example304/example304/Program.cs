using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example304
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rrd = new Random();
            int max = 0;
            int min = 101;
            for (int i = 0; i < 10; i++)
            {
                int num = rrd.Next(1,100);
                Console.Write(num + " ");
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値は{0}最小値は{1}", max, min);
        }
    }
}
