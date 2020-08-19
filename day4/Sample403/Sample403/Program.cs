using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample403
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.Name = "Kohei Ibayashi";
            p1.Age = 27;
            p2.SetAgeAndName("Hirofumi kunimitsu", 23);
            p1.ShowAgeAndName();
            Console.WriteLine("名前：{0}年齢：{1}", p2.Name, p2.Age);
        }
    }
}
