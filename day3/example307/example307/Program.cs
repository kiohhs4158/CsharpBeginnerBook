using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example307
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1, 100);
                array[i] = num;
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            string[] s = { "偶数", "奇数" };
            for (int i = 0; i <= 1; i++)
            {
                Console.Write(s[i]);
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] % 2 == i)
                    {
                        Console.Write("{0} ", array[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
