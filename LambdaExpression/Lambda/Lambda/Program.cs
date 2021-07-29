using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            //int result = squareNum(num);
            //Console.WriteLine("The num {0} multiplied by itself is {1}", num, result);
            //Console.ReadKey();

            //Func<int, int> anotherMethod = squareNum;
            //int result = anotherMethod(num);
            //Console.WriteLine("The num {0} multiplied by itself is {1}", num, result);
            //Console.ReadKey();

            /*
            Func<int,int> anotherSQR = (parameter1) =>
             {
                 return parameter1 * parameter1;
             };
            int result = anotherSQR(num);
            Console.WriteLine("The num {0} multiplied by itself is {1}", num, result);
            Console.ReadKey();
            */

            //If the body of the function can be simplified in just one row

            
            Func<int, int> MyCubeMethod = (parameter1) => parameter1 * parameter1 * parameter1;
            int result = MyCubeMethod(num);
            Console.WriteLine("The num {0} multiplied 3 times by itself is {1}", num, result);
            Console.WriteLine("");

            Func<int, int, string> returningString = (parameter1, parameter2) =>
              {
                  string tempString = "I have received the number: " + parameter1.ToString() + " and the number: " + parameter2.ToString();
                  return tempString;
              };

            Console.WriteLine(returningString(5, 6));
           

            // Just like Func with the difference we are not going to return anything
            Action printMyName = () =>
            {
                Console.WriteLine("Hi my name is Daniel");
            };

            printMyName();

            Action<string> print = (theStringToPrint) => Console.WriteLine(theStringToPrint);

            print("Hello world");
            print("Learning Lambda Expressions with Daniel Soto is awesome");
            print("Another printing statement");
            

            // Using methods that are able to receive methods as a parameters
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            Func<int, bool> IsPair = (numberToEvaluate) => numberToEvaluate % 2 == 0;

            var pairs = numbers.Where(IsPair);

            foreach(var tempNum in pairs)
            {
                Console.WriteLine("The number {0} is pair", tempNum);
            }
            Console.ReadKey();


            // Receives an Integer and a Function!!!
            Func<int, Func<int, int>, int> doSomething = (intParamter, funcParameter) =>
              {
                  if(intParamter > 23143)
                  {
                      return funcParameter(intParamter);
                  }
                  
                  return 0;
              };



        }

        static int squareNum(int tempNumber)
        {
            return tempNumber * tempNumber;
        }

        static Boolean validPair(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
