﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub s1 = new Sub();
            s1.showPrams();
            Sub s2 = new Sub(100);
            s2.showPrams();
        }
    }
}
