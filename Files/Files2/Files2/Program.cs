using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for reading files 
using System.IO;
namespace Files2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* First way to read a file */
            //string ContentOfFile = System.IO.File.ReadAllText(@"C:\Users\daniel\Desktop\DemoFiles\DanielFile.txt");
            //Console.WriteLine("This is the content of the file");
            //Console.WriteLine(ContentOfFile);
            //Console.ReadKey();

            /* Second way to read a file */
            //string[] myRows = System.IO.File.ReadAllLines(@"C:\Users\daniel\Desktop\DemoFiles\DanielFile.txt");
            //foreach(string tempRow in myRows)
            //{
            //    Console.WriteLine("This is the row: {0}", tempRow);
            //}
            //Console.ReadKey();

            /* First way to write a file */
            //string[] myRows = {"july2020 234", "august2020 234", "september 2020 234234"};
            //File.WriteAllLines(@"C:\Users\daniel\Desktop\DemoFiles\statistics.txt", myRows);
            //Console.ReadKey();

            /* Second way to wriite files*/
            string[] myRows = { "july2020 234", "august2020 234", "september 2020 234234" };
            using (StreamWriter myFile = new StreamWriter(@"C:\Users\daniel\Desktop\DemoFiles\statistics2222.txt"))
            {
                foreach (string tempRow in myRows)
                {
                    myFile.WriteLine(tempRow);
                }
            }
        }
    }
}
