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
      Bread.CostPerLoaf = 5;
      if (custBread % 3 == 0)
      {
        Bread.BreadCount = custBread - (custBread/3);
        Bread.BreadSubtotal = BreadCount * BreadCount;
      }
      else
      {

      }
      return BreadSubtotal;
    }
  }
}