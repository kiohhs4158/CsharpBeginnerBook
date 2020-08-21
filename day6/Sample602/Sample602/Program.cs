using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> a = new List<String>();
            a.Add("taro");
            a.Add("king");
            a.Add("yamada");
            a.Add("queen");
            a.Remove("taro");
            a.RemoveAt(1);
            foreach (String s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
