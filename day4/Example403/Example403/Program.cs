using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example403
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo bingo = new Bingo();
            Console.Write("サイズを入力してください：");
            int size = int.Parse(Console.ReadLine());
            bingo.Init(size);
            bingo.Show();
        }
    }
}
