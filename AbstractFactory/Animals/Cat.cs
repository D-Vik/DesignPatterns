using AbstractFactory.Interfaces;

namespace AbstractFactory.Animals
{
  public class Cat : IAnimal
  {
    public string Speak()
    {
      return "Meow Meow Mwow";
    }
  }
}
