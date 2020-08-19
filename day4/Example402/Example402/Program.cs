using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力してください：");
            string sentence = Console.ReadLine();
            Console.WriteLine("大文字：{0}", sentence.ToUpper());
            Console.WriteLine("小文字：{0}", sentence.ToLower());
        }
    }
}
