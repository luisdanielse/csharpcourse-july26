using System;

namespace Structs
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
    enum Month { Jan, Feb, March};

    class Program
    {
        static void Main(string[] args)
        {
            Figure myStructure;
            myStructure.width = 10;
            myStructure.height = 5;
            myStructure.calculateArea();

            Console.WriteLine("The first day is {0}", Day.Mo);
           

        }
    }
    
    public struct Figure
    {
        public int width;
        public int height;

        
        public void calculateArea()
        {
            Console.WriteLine("The area of this figure is: {0}", width * height);
        }

    }
}
