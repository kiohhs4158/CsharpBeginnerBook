using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample405
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.SetAgeAndName("Kohei Ibayashi", 27);
            // p.Name = "";
            p.Age = 95;
            Console.WriteLine("{0}({1})", p.Name, p.Age);
        }
    }
}
