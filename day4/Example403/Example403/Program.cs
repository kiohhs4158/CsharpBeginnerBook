﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example403
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("サイズを入力してください：");
            int size = int.Parse(Console.ReadLine());
            Bingo bingo = new Bingo();
            bingo.Show();
        }
    }
}
