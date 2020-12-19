using MyLibrary.Factory;
using MyLibrary.Factory.Interfaces;
using System;

namespace MyLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      CardFactory factory = new CardFactory();

      ICard card = factory.CreateCard("Titanium");

      Console.WriteLine(card.CardName());
      Console.WriteLine(card.AnnualCharge());
      Console.WriteLine(card.CreditLimit());
    }
  }
}
