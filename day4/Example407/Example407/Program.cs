using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example407
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student("Kohei Ibayashi", 1, 27);
            students[1] = new Student("Hirofumi Kunimitsu", 1, 23);
            students[2] = new Student("example", 5, 32);
            foreach (Student s in students)
            {
                s.ShowInformation();
            }
        }
    }
}
