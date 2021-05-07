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
  }
}