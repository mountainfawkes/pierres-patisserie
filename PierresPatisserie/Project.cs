using PierresPatisserie.Bread;
using PierresPatisserie.Pastry;
using System;
using System.Collections.Generic;

namespace PierresPatisserie
{
  public class Program
  {
    public static void Main()
    {
      // Set the prices for the day
      int breadPrice = 5;
      int pastrySinglePrice = 2;
      int pastryTrioPrice = 5;

      // Display the menu to the console

      Console.WriteLine("");
      Console.WriteLine("        BIENVENUE CHEZ PIERRE");
      Console.WriteLine("");
      Console.WriteLine("-------------Today's Menu------------");
      Console.WriteLine("        BREAD: $5 each loaf");
      Console.WriteLine("     Special: Buy 2, get 1 free");
      Console.WriteLine("------------------o------------------");
      Console.WriteLine("       PASTRIES: $2 each pastry");
      Console.WriteLine("        Special: Buy 3 for $5");
      Console.WriteLine("Today's pastry is an almond croissant");
      Console.WriteLine("-------------------------------------");

      // Prompt the user for their order

      Console.WriteLine("");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());

      // Call methods to calculate the price
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      int totalCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice) + newPastryOrder.CalculatePastryCost(pastryQuantity, pastrySinglePrice, pastryTrioPrice);

      // Return the price to the console
      Console.WriteLine("Thank you for your order!");
      Console.WriteLine("Your total cost is $" + totalCost);
    }
  }
}