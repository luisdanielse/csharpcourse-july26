using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Rectangle : Figure
    {
        int volume; 
        
        public Rectangle(int width, int height, int volume): base(width, height)
        {
            this.volume = volume;
        }

        public void greeting()
        {
            Console.WriteLine("I am a child of Figure and I am a rectangle");
        }

        public override void sayColor()
        {
            Console.WriteLine("This method has been overrided by the rectangle");
        }

        public override void calculateArea()
        {
            Console.WriteLine("the area of the rectangle is {0}", Width * Height);
        }
    }
}
