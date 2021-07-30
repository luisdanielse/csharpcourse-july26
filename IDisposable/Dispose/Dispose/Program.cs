using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFile = @"E:\visual-studiop\C#July2021\IDisposable\Dispose\Dispose\disposable.txt";

            Console.WriteLine("Press any key to create the file");
            Console.ReadKey();

            /*
            var myWriter = new WriteFile(pathFile);
            myWriter.write("the content of the file");
            myWriter.write("more content in the file");
            Console.WriteLine("File created. Press any key to exit");
            Console.ReadKey();

            var myWriter = new WriteFile(pathFile);
            var myWriter2 = new WriteFile(pathFile);
            myWriter.write("the content of the file");
            myWriter2.write("more content in the file");
            Console.WriteLine("File created. Press any key to exit");
            Console.ReadKey();
            */

        /* The using statement will look for the Dispose method
         * (declared by the interface IDisposable )*/
        using(var myWriter = new WriteFile(pathFile))
        {
            myWriter.write("This is the content of the file");
    
        }
        using (var myWriter2 = new WriteFile(pathFile))
        {
            myWriter2.write("more content in the file");

        }

            Console.WriteLine("File created. Press any key to exit");
            Console.ReadKey();

        }
    }
}
