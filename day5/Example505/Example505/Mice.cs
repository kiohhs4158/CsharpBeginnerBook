using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example505
{
    class Mice : Mammals
    {
        public Mice()
        {
            this.name = "mice";
        }
        public override void Bark()
        {
            Console.WriteLine("chu-chu-");
        }
    }
}
