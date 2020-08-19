using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example306
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int num;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}つ目の数値：", i + 1);
                num = int.Parse(Console.ReadLine());
                array[i] = num;
            }
            foreach(int j in array)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int k in array)
            {
                if (k > max)
                {
                    max = k;
                }
                if (k < min)
                {
                    min = k;
                }
            }
            Console.WriteLine("最大値は{0}", max);
            Console.WriteLine("最小値は{0}", min);
        }
    }
}
