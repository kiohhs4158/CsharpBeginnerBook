﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample204
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, d;
            int c;

            a = 1.23;
            b = (double)1.23;// キャストありで代入
            c = (int)1.23;//キャストなしで代入
            d = 10;//キャストなしで代入

            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
        }
    }
}
