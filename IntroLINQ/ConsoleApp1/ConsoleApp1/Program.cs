using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooManager zooManager = new ZooManager();


            //
            Console.Write("We are going to display a list of all the animals");
            Console.Write("Press any key to display the list:");
            Console.ReadKey();
            zooManager.ShowAnimals();
            //Console.Write("Press any key to exit");
            //Console.ReadKey();
            Console.Write("");

            /*
            Console.WriteLine("Now we are going to display the animals of an specific zoo");
            Console.WriteLine("Provide me the id of a zoo: ");
            string tempId = Console.ReadLine();
            zooManager.ShowAnimalsInAParticularZooId(tempId);
            Console.Write("Press any key to exit");
            Console.ReadKey();
            */

            Console.WriteLine("Now we are going to display the animals of an specific zoo");
            Console.WriteLine("Provide me the location of a zoo: ");
            string tempLocation = Console.ReadLine();
            zooManager.ShowAnimalsInAParticularZooLocation(tempLocation);
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }

    class ZooManager
    {
        public List<Animal> animals;
        public List<Zoo> zoos;
        public List<AnimalZoo> animalszoos;

        public ZooManager()
        {
            // Add animals
            animals = new List<Animal>();
            animals.Add(new Animal { Id = 1, Name = "Alligator", IsWild = true });
            animals.Add(new Animal { Id = 2, Name = "Tiger", IsWild = true });
            animals.Add(new Animal { Id = 3, Name = "Shark", IsWild = true });
            animals.Add(new Animal { Id = 4, Name = "Bear", IsWild = false });
            animals.Add(new Animal { Id = 5, Name = "Bird", IsWild = false });

            // Add Zoos
            zoos = new List<Zoo>();
            zoos.Add(new Zoo { Id = 1, Location = "Chicago" });
            zoos.Add(new Zoo { Id = 2, Location = "New York" });
            zoos.Add(new Zoo { Id = 3, Location = "Florida" });
            zoos.Add(new Zoo { Id = 4, Location = "Tampa Bay" });

            //Add relationships between zoo and animals
            animalszoos = new List<AnimalZoo>();

            animalszoos.Add(new AnimalZoo { Id = 1, IdAnimal = 1, IdZoo = 1 });
            animalszoos.Add(new AnimalZoo { Id = 2, IdAnimal = 2, IdZoo = 1 });
            animalszoos.Add(new AnimalZoo { Id = 3, IdAnimal = 3, IdZoo = 1 });

            animalszoos.Add(new AnimalZoo { Id = 4, IdAnimal = 3, IdZoo = 2 });
            animalszoos.Add(new AnimalZoo { Id = 5, IdAnimal = 1, IdZoo = 2 });

            Console.WriteLine("The data is ready! Let's learn LINQ Syntax");




        }

        public void ShowAnimals()
        {
            Console.WriteLine("This is the list of animals");
            IEnumerable<Animal> allAnimals = from animal in animals select animal;

            foreach(Animal tempAnimal in allAnimals)
            {
                tempAnimal.ShowAnimal();
            }
        }

        public void ShowAnimalsInAParticularZooId(string idZoo)
        {
            Console.WriteLine("The animals in the zoo with the id {0} are: ", idZoo);
            IEnumerable<Animal> animalsInZoo = from animal in animals
                                               join animalzoo in animalszoos on animal.Id equals animalzoo.Id
                                               where animalzoo.IdZoo == Int32.Parse(idZoo)
                                               select animal;
            foreach (Animal tempAnimal in animalsInZoo)
            {
                tempAnimal.ShowAnimal();
            }
        }
    
        public void ShowAnimalsInAParticularZooLocation(string location)
        {
            Console.WriteLine("The animals in the zoo of {0} are ", location);

            IEnumerable<Animal> animalsInZoo = from animal in animals
                                               join animalzoo in animalszoos on animal.Id equals animalzoo.Id
                                               join zoo in zoos on animalzoo.IdZoo
                                               equals zoo.Id
                                               where zoo.Location == location
                                               select animal;
            foreach (Animal tempAnimal in animalsInZoo)
            {
                tempAnimal.ShowAnimal();
            }
        }
    }



    class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsWild { get; set; }

        public void ShowAnimal()
        {
            Console.WriteLine("The animal with the ID {0} is {1}", Id, Name);
        }
    }

    class Zoo
    {
        public int Id { get; set; }
        public string Location { get; set; }

        public void ShowZoo()
        {
            Console.WriteLine("The zoo with the Id {0} is in {1}", Id, Location);
        }
    }

    class AnimalZoo
    {
        public int Id { get; set; }

        public int IdZoo { get; set; }
        public int IdAnimal { get; set; }

        public void showAnimalInAParticularZoo()
        {
            Console.WriteLine("I am the animal with the Id {0} and I am in the Zoo {1}", IdAnimal, IdZoo);
        }

    }

}
