using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("月を入力してください：");
            int month = int.Parse(Console.ReadLine());
            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    Console.WriteLine("{0}月の日数は{1}日です", month, days);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    Console.WriteLine("{0}月の日数は{1}日です", month, days);
                    break;
                case 2:
                    days = 28;
                    int leap_year = 29;
                    Console.WriteLine("{0}月の日数は{1}日です（うるう年は{2}日）", month, days, leap_year);
                    break;
                default:
                    Console.WriteLine("範囲外の数値です");
                    break;
            }
        }
    }
}
