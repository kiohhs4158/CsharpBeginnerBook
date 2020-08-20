using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    class Sparrow
    {
        private String name = "スズメ";
        public void Sing()
        {
            Console.WriteLine("chunchun");
        }
        public string Name
        {
            get { return name; }
        }
    }
}
