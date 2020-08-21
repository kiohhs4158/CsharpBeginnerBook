using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example506
{
    class Program
    {
        static void DriveACar(IDrive car)
        {
            car.Drive();
        }
        static void MaintainACar(IMechanical car)
        {
            car.Maintain();
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            DriveACar(c);
            MaintainACar(c);
        }
    }
}
