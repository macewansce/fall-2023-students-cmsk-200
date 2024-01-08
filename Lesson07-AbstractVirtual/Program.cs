using System;
using System.Collections.Generic;

namespace Module2.Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());

            foreach(Animal animal in animals)
            {
                Console.WriteLine($"This {animal.Name()} says {animal.Speak()}");
            }



        }
    }
}
