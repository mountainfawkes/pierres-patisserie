using System;
using System.Collections.Generic;

namespace PierresPatisserie.Bread
{
  public class BreadOrder
  {
    public int BreadQuantity;
    public int BreadPrice;
    public int BreadCost;
    
    public BreadOrder(int breadQuantity, int breadPrice)
    {
      BreadQuantity = breadQuantity;
      BreadPrice = breadPrice;
    }

    public int CalculateBreadCost(int breadQuantity, int breadPrice)
    {
      if (breadQuantity % 3 == 0)
      {
        return ((breadQuantity * 2) / 3) * breadPrice;
      }
      else if (breadQuantity % 3 == 1)
      {
        return ((((breadQuantity - 1) * 2) / 3) + 1) * breadPrice;
      }
      else return breadQuantity * breadPrice;
    }
  }
}