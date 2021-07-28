using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace for SqlConnection:
using System.Data.SqlClient;
namespace ExternalDB_Console
{
    class Program
    {
        static DataClasses1DataContext dataContext;
        static void Main(string[] args)
        {
            string connectionString = "Server=tcp:danielssql234.database.windows.net,1433;Initial Catalog=DBTest;Persist Security Info=False;User ID=testuser;Password=TestPa55w.rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            dataContext = new DataClasses1DataContext(connectionString);

            var listOfAnimals = from animal in dataContext.Animals select animal;

            foreach(var tempAnimal in listOfAnimals)
            {
                Console.WriteLine("This is the animal: {0}", tempAnimal.Name);
            }


            Console.WriteLine("");
            Console.WriteLine("This is the list of zoos");
            var listOfZoos = from zoo in dataContext.Zoos select zoo;
            foreach (var tempZoo in listOfZoos)
            {
                Console.WriteLine("This is the zoo: {0}", tempZoo.Location);
            }
            Console.ReadKey();
        }
    }
}
