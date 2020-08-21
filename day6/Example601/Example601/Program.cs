using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example601
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            while (true)
            {
                Console.Write("正の整数を入力してください：");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    a.Add(num);
                }
                else
                {
                    break;
                }
            }
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"合計値{a.Sum()}");
            Console.WriteLine($"平均値{a.Average()}");
            Console.WriteLine($"最大値{a.Max()}");
            Console.WriteLine($"最小値{a.Min()}");
        }
    }
}
