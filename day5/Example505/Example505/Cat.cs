using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example505
{
    class Cat : Mammals
    {
        public Cat()
        {
            this.name = "cat";
        }
        public override void Bark()
        {
            Console.WriteLine("nyannnyann");
        }
    }
}
