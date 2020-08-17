using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example203
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, avg;
            Console.Write("num1 = ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            num2 = double.Parse(Console.ReadLine());
            avg = (num1 + num2) / 2.0;
            Console.WriteLine("num1とnum2の平均値は{0}です", avg);
        }
    }
}
