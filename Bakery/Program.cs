using System;
using Bakery.Models;
// using otherthings;

namespace MyProgram {
  class Program {
    static void Main(){
      Console.WriteLine("Bonjour! Today we sell bread at $5 (buy two, third is free!) and pastries starting at $2 (every third is half off!)");
      Console.WriteLine("===================================================================================================================");
      Console.WriteLine("How many loaves of bread would you like?");
      int custBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int custPastry = int.Parse(Console.ReadLine());
      int custTotal = AssembleOrder(custBread, custPastry);
      Console.WriteLine($"Your total today for {custBread} loaves and {custPastry} pastry is ${custTotal}, merci!"); 
      Console.WriteLine();  
    }

    public static int AssembleOrder(int custBread, int custPastry)
    {
      int orderTotal = (Bread.BreadTotal(custBread) + Pastry.PastryTotal(custPastry));
      return orderTotal;
    }
  }
}