using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example505
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammals[] animals = new Mammals[2];
            animals[0] = new Cat();
            animals[1] = new Mice();
            for (int i= 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Bark();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
