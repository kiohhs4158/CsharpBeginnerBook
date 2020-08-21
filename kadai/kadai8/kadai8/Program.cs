using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace kadai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("テキストを入力してください：");
            string text = Console.ReadLine();
            Log.Write(text);
            Console.WriteLine("終了します");
        }
    }
}
