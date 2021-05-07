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
      // Display the menu to the console

      Console.WriteLine("BIENVENUE CHEZ PATISSERIE DE PIERRE");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Today's prices:");
      Console.WriteLine("BREAD: $5 each loaf");
      Console.WriteLine("Special: Buy 2, get 1 free");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("PASTRIES: today's pastry is an almond croissant");
      Console.WriteLine("$2 each pastry");
      Console.WriteLine("Special: Buy 3 for $5");
      Console.WriteLine("-----------------------------------");

      // Prompt the user for their order

      Console.WriteLine("How many loaves of bread would you like?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryOrder = int.Parse(Console.ReadLine());

      // Call methods to calculate the price

      // Return the price to the console
    }
  }
}