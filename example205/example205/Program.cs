using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください:");
            string word = Console.ReadLine();
            if (word.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Helloと入力されました");
            }
            else
            {
                Console.WriteLine("Helloと入力してください");
            }
        }
    }
}
