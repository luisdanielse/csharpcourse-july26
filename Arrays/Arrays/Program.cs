using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] scores = new int[] { 9, 9, 10, 8, 10, 9 };
            
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(25);
            myArrayList.Add("Hello World");
            myArrayList.Add(23423.34234);
            
            int summatory = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                int temporaryNumber = scores[i];
                Console.WriteLine("The number in index {0} is {1}", i, temporaryNumber);
                summatory = summatory + temporaryNumber;
            }

            Console.WriteLine("The summatory of the array is: {0}", summatory);
            */


            // Specify width and height (BAD PRACTICE)
            //myRectangle.width = 5;
            //myRectangle.height = 10;

            // Specify width and height with a constructor (Better than the "bad practice")
            Rectangle myRectangle = new Rectangle(5,10);

            int areaOfRectangle = myRectangle.calculateArea();
            Console.WriteLine("The area of the rectangle is {0}", areaOfRectangle);

        }
    }
}
