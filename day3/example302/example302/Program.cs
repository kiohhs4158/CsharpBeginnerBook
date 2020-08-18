using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力してください：");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("正の整数が入力されませんでした");
            }
        }
    }
}
