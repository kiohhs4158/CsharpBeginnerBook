using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample401
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.name = "Kohei Ibayashi";
            p1.age = 27;
            p2.SetAgeAndName("Hirofumi Kunimitsu", 23);
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
