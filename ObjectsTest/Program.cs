using System;
using System.Collections.Generic;
using System.Linq;
using Objects;

namespace ObjectsTest
{
    class Program
    {
        static void Main()
        {
            var animal = new Animal { Age = 1, Name = "Animal", Weight = 3 };
            var bird = new Bird { Age = 10, Name = "Bird", Weight = 8 };
            var cat = new Cat { Age = 5, Name = "Cat", Weight = 18 };
            var dog = new Dog { Age = 20, Name = "Dog", Weight = 14 };

            Fly(bird);
            Move(cat);
            Move(dog);

            var animals = new List<Animal> { animal, bird, cat, dog };
            Console.WriteLine("Unordered animals collection:");
            WriteAnimals(animals);
            animals = animals.OrderBy(x => x.Age).ToList();
            Console.WriteLine("Animals ordered by age:");
            WriteAnimals(animals);
            animals = animals.OrderByDescending(x => x.Weight).ToList();
            Console.WriteLine("Animals ordered by weight by descending:");
            WriteAnimals(animals);

            Console.ReadKey();
        }

        private static void WriteAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("Age: {0}, Name: {1}, Weight: {2}", animal.Age, animal.Name, animal.Weight);
            }
        }

        private static void Move(IMovable movableAnimal)
        {
            movableAnimal.Move();
        }

        private static void Fly(IFlyeble flyebleAnimal)
        {
            flyebleAnimal.Fly();
        }
    }
}
