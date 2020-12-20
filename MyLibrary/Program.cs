using MyLibrary.AbstractFactory;
using MyLibrary.AbstractFactory.Interfaces;
using System;

namespace MyLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      AnimalFactory factory = AnimalFactory.CreateAnimalFactory("Land");

      IAnimal dog = factory.GetAnimal("Dog");

      Console.WriteLine(dog.Speak());
    }
  }
}
