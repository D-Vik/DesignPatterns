using AbstractFactory.Interfaces;

namespace AbstractFactory.Animals.SeaAnimals
{
  public class Octopus : IAnimal
  {
    public string Speak()
    {
      return "Squawck";
    }
  }
}
