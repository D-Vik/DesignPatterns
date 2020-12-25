using Factory.Interfaces;
using System;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      CardFactory factory = new CardFactory();

      ICard card = factory.CreateCard("MoneyBack");
      ICard card1 = factory.CreateCard("Titanium");

      Console.WriteLine(
        $"Card name: {card.CardName()}," +
        $" Credit limit: {card.CreditLimit()}," +
        $" Annual Charge: {card.AnnualCharge()}"
      );

      Console.WriteLine(
        $"Card name: {card1.CardName()}," +
        $" Credit limit: {card1.CreditLimit()}," +
        $" Annual Charge: {card1.AnnualCharge()}"
      );
    }
  }
}
