using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example408
{
    class Hoo
    {
        public Hoo()
        {
            Console.WriteLine("Hooクラスのインスタンスが生成されました");
        }
        public void Foo()
        {
            Console.WriteLine("fooメソッドが実行されました");
        }
        ~Hoo()
        {
            Console.WriteLine("Hooクラスのインスタンスが消去されました");
        }
    }
}
