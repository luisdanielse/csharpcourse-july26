using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Rectangle
    {
        private int width;
        private int height;


        public Rectangle(int width_, int height_)
        {
            width = width_;
            height = height_;
        }

        public int calculateArea()
        {
            return width * height;
        }
    }
}
