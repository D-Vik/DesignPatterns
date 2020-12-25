using Factory.Interfaces;

namespace Factory.Cards
{
  public class Titanium : ICard
  {
    public string CardName()
    {
      return "Titanium";
    }

    public int AnnualCharge()
    {
      return 1000;
    }

    public int CreditLimit()
    {
      return 25000;
    }
  }
}
