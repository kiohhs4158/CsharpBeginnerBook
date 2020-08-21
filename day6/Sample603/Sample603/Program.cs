using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample603
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> capital = new Dictionary<String, String>();
            capital["Japan"] = "Tokyo";
            capital["UK"] = "London";
            capital["France"] = "Paris";
            capital["China"] = "Beijing";
            Console.WriteLine("世界の首都");
            foreach (String s in capital.Keys)
            {
                Console.WriteLine($"{s}の首都は{capital[s]}");
            }
        }
    }
}
