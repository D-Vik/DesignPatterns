using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      AnimalFactory landAnimals = AnimalFactory.CreateAnimalFactory("Land");
      AnimalFactory seaAnimals = AnimalFactory.CreateAnimalFactory("Sea");

      IAnimal lion = landAnimals.GetAnimal("Lion");
      IAnimal dog = landAnimals.GetAnimal("Dog");

      IAnimal shark = seaAnimals.GetAnimal("Shark");
      IAnimal octopus = seaAnimals.GetAnimal("Octopus");


      Console.WriteLine($"Lion speak: {lion.Speak()}");
      Console.WriteLine($"Dog speak: {dog.Speak()}");

      Console.WriteLine($"Shark speak: {shark.Speak()}");
      Console.WriteLine($"Octopus speak: {octopus.Speak()}");
    }
  }
}
