using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example502
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("角度を入力：");
            double angle = double.Parse(Console.ReadLine());
            double rad = Math.PI * angle / 180.0;
            Console.WriteLine("sin{0}° = {1}", angle, Math.Sin(rad));
            Console.WriteLine("cos{0}° = {1}", angle, Math.Cos(rad));
            Console.WriteLine("tan{0}° = {1}", angle, Math.Tan(rad));
        }
    }
}
