using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example401
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r;
            r = new Rectangle();
            Console.Write("幅（cm）");
            r.width = double.Parse(Console.ReadLine());
            Console.Write("高さ（cm）");
            r.height = double.Parse(Console.ReadLine());
            double area = r.GetArea();
            double perimeter = r.GetPerimeter();
            Console.WriteLine("面積：{0}cm2", area);
            Console.WriteLine("周の長さ：{0}cm", perimeter);
        }
    }
}
