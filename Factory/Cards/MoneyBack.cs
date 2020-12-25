using Factory.Interfaces;

namespace Factory.Cards
{
  public class MoneyBack : ICard
  {
    public string CardName()
    {
      return "Money Back";
    }

    public int AnnualCharge()
    {
      return 500;
    }

    public int CreditLimit()
    {
      return 15000;
    }
  }
}
