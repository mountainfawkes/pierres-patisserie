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
      else if (pastryQuantity % 3 == 1 || pastryQuantity % 3 == 2)
      {
        int remainder = pastryQuantity % 3;
        return (pastryQuantity - remainder) / 3 * pastryTrioPrice + remainder * pastrySinglePrice;
      }
      return pastryQuantity * pastrySinglePrice;
    }
  }
}