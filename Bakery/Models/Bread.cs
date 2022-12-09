using System;

namespace Bakery.Models
{
  public class Bread
  {
    public static int BreadCount { get; set; }
    public static int CostPerLoaf { get; set; }
    public static int BreadSubtotal { get; set; }

    public static int BreadTotal(int custBread)
    {
      CostPerLoaf = 5;
      if (custBread % 3 == 0)
      {
        BreadCount = custBread - (custBread / 3);
      }
      else if (custBread % 3 == 2)
      {
        BreadCount = custBread - ((custBread - 2) / 3 );
      }
      else 
      {
        BreadCount = custBread - ((custBread - 1) / 3 );
      }
      BreadSubtotal = BreadCount * CostPerLoaf;
      return BreadSubtotal;
    }
  }
}