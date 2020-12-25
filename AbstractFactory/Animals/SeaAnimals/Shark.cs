using AbstractFactory.Interfaces;

namespace AbstractFactory.Animals.SeaAnimals
{
  public class Shark : IAnimal
  {
    public string Speak()
    {
      return "Cannot speak";
    }
  }
}
