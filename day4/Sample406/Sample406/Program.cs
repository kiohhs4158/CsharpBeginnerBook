using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person("Hirofumi Kunimitsu", 23);
            p1.Name = "Kohei Ibayashi";
            p1.Age = 27;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
