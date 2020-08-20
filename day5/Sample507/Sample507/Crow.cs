using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    class Crow
    {
        private String name = "カラス";
        public void Sing()
        {
            Console.WriteLine("ca-ca-");
        }
        public string Name
        {
            get { return name; }
        }
    }
}
