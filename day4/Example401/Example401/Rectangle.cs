using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example401
{
    class Rectangle
    {
        private double width = 0;
        private double height = 0;

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return (width + height) * 2;
        } 

        public double Width
        {
            set { width = value; }
            get { return width; }
        }

         public double Height
        {
            set { height = value; }
            get { return height; }
        }
    }
}
