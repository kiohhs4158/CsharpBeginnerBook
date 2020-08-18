using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数当てゲーム");
            Console.WriteLine("0から10の数字を入力してください");
            Random rrd = new Random();
            int r_num = rrd.Next(1, 10);
            int counter = 1;
            int i_num;
            while (counter <= 3)
            {
                Console.Write("{0}回目：", counter);
                i_num = int.Parse(Console.ReadLine());
                if (i_num == r_num)
                {
                    Console.WriteLine("正解です");
                    break;
                }
                else if (i_num > r_num)
                {
                    Console.WriteLine("大きすぎます");
                }
                else if (i_num < r_num)
                {
                    Console.WriteLine("小さすぎます");
                }
                counter++;
            }
            if (counter == 4)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("正解は{0}", r_num);
            }
        }
    }
}
