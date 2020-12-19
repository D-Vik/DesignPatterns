using MyLibrary.Factory.Cards;
using MyLibrary.Factory.Interfaces;

namespace MyLibrary.Factory
{
  public class CardFactory
  {
    public ICard CreateCard(string name)
    {
      switch (name)
      {
        case "MoneyBack": return new MoneyBack();
        case "Titanium": return new Titanium();
        case "Platinum": return new Platinum();
        default: return null;
      }
    }
  }
}
