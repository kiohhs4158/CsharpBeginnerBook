using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example505
{
    abstract class Mammals
    {
        protected string name = "";
        public abstract void Bark();
        public void ShowName()
        {
            Console.WriteLine("name:{0}", name);
        }
    }
}
