using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncTasks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Chef tempChef = new Chef();

            Console.WriteLine("We are about to see the chef working. Press any key to start the process");
            Console.ReadKey();
            //tempChef.GrillMeat();
            //tempChef.CookChicken();

            //tempChef.GrillMeatAsyncWithTask();
            //tempChef.CookChicken();

            /* In order to use the await statement the method must be async 
             *  static async Task Main(string[] args)
             */

            Console.WriteLine("This was printed before the chef returns the random number");
            int tempNumber = await tempChef.getRandomNumberWithDelay();
            Console.WriteLine("This was printed after the chef returns the random number");
            Console.WriteLine("This was printed after the chef returns the random number");
            Console.WriteLine("This was printed after the chef returns the random number");

            Console.WriteLine("This is the number: {0}", tempNumber.ToString());


            Console.ReadKey();
        }
    }

    public class Chef
    {
        public void GrillMeat()
        {
            Console.WriteLine("Put the meat in the grill");
            Thread.Sleep(6000);
            Console.WriteLine("Get the meat from the grill");
        }

        public void CookChicken()
        {
            Console.WriteLine("Put the chicken in the oven");
            Thread.Sleep(5000);
            Console.WriteLine("Get the chicken from the oven");
        }

        public async Task GrillMeatAsync()
        {
            Console.WriteLine("Put the meat in the grill (async)");
            await Task.Delay(6000);
            Console.WriteLine("Get the meat from the grill (async)");
           
        }


        public async Task GrillMeatAsyncWithTask()
        {
            var task = new Task(() => {
                Console.WriteLine("Put the meat in the grill  (async 22)");
                Thread.Sleep(6000);
            });

            task.Start();
            await task;
            Console.WriteLine("Get the meat from the grill (async 22)");
        }

        public async Task<int> getRandomNumber()
        {
            // The empty parenthesis means we are not receiving parameters in the lambda expression
            var task = new Task<int>(() => new Random().Next(1000));
            task.Start();
            int result = await task;
            return result;
        }

        public async Task<int> getRandomNumberWithDelay()
        {
            // The empty parenthesis means we are not receiving parameters in the lambda expression
            var task = new Task<int>(   ( ) => {
                Thread.Sleep(3000);
                return new Random().Next(1000);
                });
            task.Start();
            int result = await task;
            return result;
        }
    }
}
