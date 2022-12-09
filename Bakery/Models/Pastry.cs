using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public static int PastryCount { get; set;}
    public static int CostPerPastry { get; set;}
    public static int PastrySubtotal { get; set;}
    
    public static int PastryTotal(int custPastry)
    {
      CostPerPastry = 2;
      if (custPastry % 3 == 0)
      {
        PastrySubtotal = (custPastry * CostPerPastry) - ((custPastry / 3) * 1);
      }
    return PastrySubtotal;
    }
  }
}