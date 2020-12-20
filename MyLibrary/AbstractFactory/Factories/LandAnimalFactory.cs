﻿using MyLibrary.AbstractFactory.Animals;
using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Factories
{
  public class LandAnimalFactory : AnimalFactory
  {
    public override IAnimal GetAnimal(string type)
    {
      switch (type)
      {
        case "Dog": return new Dog();
        case "Cat": return new Cat();
        case "Lion": return new Lion();
        default: return null;
      }
    }
  }
}
