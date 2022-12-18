using System;

namespace Bakery.Models
{
  public class Bread
  {
    // public int BreadSubtotal { get; set; }
    public int CostPerLoaf { get; set; }
    // public static int BreadSubtotal { get; set; }

    public static int BreadTotal(int custBread)
    {
      int CostPerLoaf = 5;
      int BreadSubtotal = 0;

      if (custBread % 3 == 0)
      {
        BreadSubtotal = (custBread * CostPerLoaf) - ((custBread / 3) * CostPerLoaf);
      }
      else if (custBread % 3 == 2)
      {
        BreadSubtotal = (custBread * CostPerLoaf) - ((custBread / 3 ) * CostPerLoaf);
      }
      else if (custBread % 3 == 1)
      {
        BreadSubtotal = (custBread * CostPerLoaf) - ((custBread  / 3 )* CostPerLoaf);
      }
      // BreadSubtotal = BreadSubtotal * CostPerLoaf;
      return BreadSubtotal;
    }
  }
}