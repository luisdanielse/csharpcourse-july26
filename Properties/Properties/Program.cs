using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create a figure");
            Figure myFigure = new Figure(10, 5);
            myFigure.Color = "Red";
            myFigure.sayColor();
            Console.WriteLine("Now invoking a static method");
            Figure.saySomething();
            Console.WriteLine("");
            Console.WriteLine("Now let's use inheritance");
            Rectangle myRectangle = new Rectangle(8, 6, 23);
            myRectangle.Color = "Blue";
            myRectangle.sayColor();
            myRectangle.greeting();


        }
    }
}
