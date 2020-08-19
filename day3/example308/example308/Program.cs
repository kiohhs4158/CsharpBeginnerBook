using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example308
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                int num = rnd.Next(1, 100);
                array[i] = num;
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int max = 0;
                int pos = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > 0)
                    {
                        max = array[j];
                        pos = j;
                    }
                }
                Console.Write("{0} ", max);
                array[pos] = 0;
            }
            Console.WriteLine();
        }
    }
}
