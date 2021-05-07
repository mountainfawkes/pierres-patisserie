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
      if (pastryQuantity % 3 == 0)
      {
        return (pastryQuantity / 3) * 5;
      }
      return pastryQuantity * pastryPrice;
    }
  }
}