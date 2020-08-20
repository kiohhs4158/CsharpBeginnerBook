using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample511
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            IFuncs i1 = (IFuncs)d;
            IFuncs2 i2 = (IFuncs2)d;
            i1.Func1();
            i1.Func2();

            i2.Func2();
            i2.Func3();
        }
    }
}
