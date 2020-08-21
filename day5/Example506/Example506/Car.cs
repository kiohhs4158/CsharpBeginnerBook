using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example506
{
    class Car : IDrive, IMechanical
    {
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        public void Maintain()
        {
            Console.WriteLine("メンテする");
        }
    }
}
