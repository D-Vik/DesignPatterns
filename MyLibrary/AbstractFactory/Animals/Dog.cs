using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Animals
{
  public class Dog : IAnimal
  {
    public string Speak()
    {
      return "Woof Woof";
    }
  }
}
