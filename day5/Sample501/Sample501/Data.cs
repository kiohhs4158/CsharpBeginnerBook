using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample501
{
    class Data
    {
        private static int num = 0;
        private int id;
        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("id{0}、データの数{1}", this.id, num);
        }
        public static void ShowNumber()
        {
            Console.WriteLine("Dataのオブジェクトの数{0}", num);
        }
    }
}
