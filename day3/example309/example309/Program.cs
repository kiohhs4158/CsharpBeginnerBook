using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example309
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                int num = rnd.Next(1, 99);
                array[i] = num;
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            for (int i = 0; i < 100; i += 10)
            {
                Console.Write("{0}以上{1}未満：", i, i + 10);
                foreach (int j in array)
                {
                    if (j > i && j <= i + 10)
                    {
                        Console.Write("{0} ", j);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
