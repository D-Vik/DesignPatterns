using AbstractFactory.Interfaces;
using AbstractFactory.Animals.SeaAnimals;

namespace AbstractFactory.Factories
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
