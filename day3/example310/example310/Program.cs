using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example310
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            int[,] array = new int[SIZE, SIZE];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = 0;
                }
            }
            Random rnd = new Random();
            int num = 1;
            while (num <= SIZE * SIZE)
            {
                while (true)
                {
                    int m = rnd.Next(SIZE);
                    int n = rnd.Next(SIZE);
                    if (array[m, n] == 0)
                    {
                        array[m, n] = num;
                        num++;
                        break;
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0, 2:d}|", array[i, j]);
                }
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("---");
                }
                Console.WriteLine();
            }
        }
    }
}
