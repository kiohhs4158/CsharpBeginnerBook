using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504
{
    class Super
    {
        private int param = 0;
        public Super()
        {
            Console.WriteLine("Superクラスのコンストラクタ（引数なし）");
        }
        public Super(int param)
        {
            Console.WriteLine("param = {0}", param);
            this.param = param;
        }
        ~Super()
        {
            Console.WriteLine("Superクラスのデストラクタ");
        }
        public void showPrams()
        {
            Console.WriteLine("param = {0}", param);
        }
    }
}
