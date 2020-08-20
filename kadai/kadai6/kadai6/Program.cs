using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai6
{
    class Program
    {
        static void Main(string[] args)
        {
            string kadai1 = "abcdefghi";
            int kadai2 = 123;
            Console.WriteLine("文字数取得：{0}", kadai1.Length);

            kadai1 = kadai1.ToUpper();
            Console.WriteLine("大文字：{0}", kadai1);

            kadai1 = kadai1.ToLower();
            Console.WriteLine("小文字：{0}", kadai1);

            kadai1 = kadai1.PadLeft(20);
            kadai1 = kadai1.PadRight(20);
            Console.WriteLine("空白追加：{0}", kadai1);
            kadai1 = kadai1.Trim();
            Console.WriteLine("空白削除：{0}", kadai1);

            Console.WriteLine("int {0} => string {1}", kadai2, kadai2.ToString());

            char c1 = kadai1[2];
            Console.WriteLine("3番目の文字：{0}", c1);

            Console.WriteLine("2番目から5番目のの文字：{0}", kadai1.Substring(1, 4));

            for (int i = 0; i < kadai1.Length; i++)
            {
                char c = kadai1[i];
                if (c == 'f')
                {
                    Console.WriteLine("{0}は{1}番目にあります", c, i + 1);
                }
            }

            string kadai3 = "abcabcabc";
            Console.WriteLine("a => x：{0}", kadai3.Replace('a', 'x'));

            kadai1 = kadai1.Insert(3, " ");
            kadai1 = kadai1.Insert(7, " ");
            Console.WriteLine("空白挿入：{0}", kadai1);
            string[] kadai1_arr = kadai1.Split(' ');
            Console.WriteLine("文字列連結：{0}", string.Join(",", kadai1_arr));

            string kadai2_str = kadai2.ToString();
            int kadai2_num = int.Parse(kadai2_str);
            Console.WriteLine("string {0} => int {1}", kadai2_str, kadai2_num);
            Console.WriteLine("文字列判定：{0}", kadai2_num is String);
        }
    }
}
