using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample503
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            c.Num1 = 10;
            c.Num2 = 3;
            c.add();
            c.sub();

            ExCalc e = new ExCalc();
            e.Num1 = 20;
            e.Num2 = 3;
            e.add();
            e.sub();
            e.mul();
            e.div();
        }
    }
}
