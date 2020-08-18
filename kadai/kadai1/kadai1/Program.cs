using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数の値を入れ替える
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("aに{0},bに{1}が代入されています", a, b);
            Console.Write("changeと入力してください：");
            string s = Console.ReadLine();
            if (s.Equals("change", StringComparison.OrdinalIgnoreCase))
            {
                int c = a;
                a = b;
                b = c;
                Console.WriteLine("aに{0},bに{1}が代入されています", a, b);
            }
            else
            {
                Console.WriteLine("changeと入力してください");
            }
        }
    }
}
