using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example405
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください：");
            string sentence = Console.ReadLine();
            Console.WriteLine("文字列の長さ：{0}",sentence.Length);
        }
    }
}
