using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("H2Oの温度：");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature >= 100.0)
            {
                Console.WriteLine("気体です");
            }
            else if (temperature > 0.0)
            {
                Console.WriteLine("液体です");
            }
            else
            {
                Console.WriteLine("固体です");
            }
        }
    }
}