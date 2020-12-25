using AbstractFactory.Interfaces;
using AbstractFactory.Factories;

namespace AbstractFactory
{
  public abstract class AnimalFactory
  {
    public abstract IAnimal GetAnimal(string type);

    public static AnimalFactory CreateAnimalFactory(string type)
    {
      switch (type)
      {
        case "Sea": return new SeaAnimalFactory();
        case "Land": return new LandAnimalFactory();
        default: return null;
      }
    }
  }
}
