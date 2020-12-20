using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Animals.SeaAnimals
{
  public class Shark : IAnimal
  {
    public string Speak()
    {
      return "Cannot speak";
    }
  }
}
