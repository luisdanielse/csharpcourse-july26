using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    abstract class Figure
    {
        private int width;
        private int height;
        public string Color { get; set; } 

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }
        public Figure(int width, int height) 
        {
            this.width = width;
            this.height = height;

        }

        // In order to overwrite an existing method we must
        // use the reserve word "virtual"
        public virtual void sayColor()
        {
            Console.WriteLine("My color is {0}", Color);
        }
        
        public static void saySomething()
        {
            Console.WriteLine("A figure is very useful in maths");
        }

        public abstract void calculateArea();
    }
}
