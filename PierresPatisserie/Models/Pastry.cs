using System;
using System.Collections.Generic;

namespace PierresPatisserie.Pastry
{
  public class PastryOrder
  {
    public int PastryQuantity;
    public int PastryPrice;
    public int PastryCost;
    
    public PastryOrder(int pastryQuantity, int pastryPrice)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = pastryPrice;
    }

    public int CalculatePastryCost(int pastryQuantity, int pastryPrice)
    {
      return pastryQuantity * pastryPrice;
    }
  }
}