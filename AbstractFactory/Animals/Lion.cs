using AbstractFactory.Interfaces;

namespace AbstractFactory.Animals
{
  public class Lion : IAnimal
  {
    public string Speak()
    {
      return "Roar";
    }
  }
}
