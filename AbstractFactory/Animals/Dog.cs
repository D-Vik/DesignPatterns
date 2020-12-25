using AbstractFactory.Interfaces;

namespace AbstractFactory.Animals
{
  public class Dog : IAnimal
  {
    public string Speak()
    {
      return "Woof Woof";
    }
  }
}
