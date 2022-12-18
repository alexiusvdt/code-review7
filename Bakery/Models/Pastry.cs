using System;

namespace Bakery.Models
{
  public class Pastry
  {
    // public int PastryCount { get; set;}
    public static int CostPerPastry { get; set;}
    public static int PastrySubtotal { get; set;}
    
    public static int PastryTotal(int custPastry)
    {
      CostPerPastry = 2;
      // old pastry logic
      // if (custPastry % 3 == 0)
      // {
      //   PastrySubtotal = (custPastry * CostPerPastry) - ((custPastry / 3) * 1);
      // }
      if(custPastry % 3 == 0)
      {
        PastrySubtotal = (custPastry * 2) - ((custPastry / 3) * 1);
      }
      else if (custPastry % 3 == 2)
      {
         PastrySubtotal = (custPastry * 2) - ((custPastry - 2) / 3 * 1);
      }
      else if (custPastry % 3 == 1)
      {
         PastrySubtotal =  (custPastry * 2) -((custPastry - 1) / 3 * 1);
      }
   
    return PastrySubtotal;
    }
  }
}