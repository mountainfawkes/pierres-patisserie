using System;
using System.Collections.Generic;

namespace PierresPatisserie.Pastry
{
  public class PastryOrder
  {
    public int PastryQuantity;
    public int PastrySinglePrice;
    public int PastryTrioPrice;
    public int PastryCost;
    
    public PastryOrder(int pastryQuantity, int pastrySinglePrice, int pastryTrioPrice)
    {
      PastryQuantity = pastryQuantity;
      PastrySinglePrice = pastrySinglePrice;
      PastryTrioPrice = pastryTrioPrice;
    }

    public int CalculatePastryCost(int pastryQuantity, int pastrySinglePrice, int pastryTrioPrice)
    {
      if (pastryQuantity % 3 == 0)
      {
        return (pastryQuantity / 3) * pastryTrioPrice;
      }
      return pastryQuantity * pastrySinglePrice;
    }
  }
}