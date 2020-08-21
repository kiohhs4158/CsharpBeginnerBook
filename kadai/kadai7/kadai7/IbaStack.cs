using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai7
{
    class IbaStack
    {   
        private string[] data;
        public int num = 0;

        public IbaStack(int size)
        {
            data = new string[size];
        }

        public void Push(string fruits)
        {
            data[num] = fruits;
            num++;
        }

        public string Pop()
        {
            num--;
            return data[num];
        }
    }
}
