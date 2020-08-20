using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample502
{
    class Program
    {
        private static int snum = 100;
        public int inum = 200;
        public static void Foo()
        {
            Console.WriteLine("fooメソッド(staticメソッド)");
        }
        public void Bar()
        {
            Console.WriteLine("barメソッド(インスタンスメソッド)");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("pのインスタンスフィールド：{0}", p.inum);
            Console.WriteLine("pのクラスフィールド：{0}", snum);
            Foo();
            p.Bar();
        }
    }
}
