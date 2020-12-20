using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Animals
{
  public class Cat : IAnimal
  {
    public string Speak()
    {
      return "Meow Meow Mwow";
    }
  }
}
