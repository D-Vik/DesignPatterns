using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Animals.SeaAnimals
{
  public class Octopus : IAnimal
  {
    public string Speak()
    {
      return "Squawck";
    }
  }
}
