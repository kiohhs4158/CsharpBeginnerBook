using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 階段
            string[,] stairs = new string[5, 5];
            for (int i = 0; i < stairs.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    stairs[i, j] = "■";
                    Console.Write(stairs[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
