using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Text.Json;
using System.Text.Json.Serialization;

namespace serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Daniel = new Human("Daniel Soto", 30);

            string DanielJson = JsonSerializer.Serialize(Daniel);
            Console.WriteLine(DanielJson);


        }
    }

    class Human
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string Name_, int Age_)
        {
            Name = Name_;
            Age = Age_;
        }
    }
}
