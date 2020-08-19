using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pyramid = new string[4, 7];
            const string PARTS = "■";
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int j = 0; j < pyramid.GetLength(1); j++)
                {
                    pyramid[i, j] = "　";
                }
            }
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    pyramid[i, 3] = PARTS;
                    pyramid[i, 3 + j] = PARTS;
                    pyramid[i, 3 - j] = PARTS;
                }
            }
            for (int i = 0; i < pyramid.GetLength(0); i++)
            {
                for (int j = 0; j < pyramid.GetLength(1); j++)
                {
                    Console.Write(pyramid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
