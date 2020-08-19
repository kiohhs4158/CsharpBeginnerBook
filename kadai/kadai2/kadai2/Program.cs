using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // バブルソートアルゴリズム
            // 配列を定義
            int[] array = { 8, 4, 3, 7, 6, 5, 2, 1 };
            Console.WriteLine("元の配列");
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int x = i + 1;
                for (int j = 0; j < array.Length - x; j++)
                {
                    if(array[j] < array[j + 1])
                    {
                        int replace = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = replace;
                    }
                }
            }
            Console.WriteLine("バブルソート");
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
