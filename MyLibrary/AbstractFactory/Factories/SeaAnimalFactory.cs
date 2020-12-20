using MyLibrary.AbstractFactory.Animals.SeaAnimals;
using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Factories
{
  public class SeaAnimalFactory : AnimalFactory
  {
    public override IAnimal GetAnimal(string type)
    {
      switch (type)
      {
        case "Shark": return new Shark();
        case "Octopus": return new Octopus();
        default: return null;
      }
    }
  }
}
