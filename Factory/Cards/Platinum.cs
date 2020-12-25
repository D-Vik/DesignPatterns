using Factory.Interfaces;

namespace Factory.Cards
{
  public class Platinum : ICard
  {
    public string CardName()
    {
      return "Platinum";
    }

    public int AnnualCharge()
    {
      return 2000;
    }

    public int CreditLimit()
    {
      return 35000;
    }
  }
}
