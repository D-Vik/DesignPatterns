using MyLibrary.AbstractFactory.Interfaces;

namespace MyLibrary.AbstractFactory.Animals
{
  public class Lion : IAnimal
  {
    public string Speak()
    {
      return "Roar";
    }
  }
}
