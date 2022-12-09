using System;
using Bakery.Models;
// using otherthings;

namespace MyProgram {
  class Program {
    static void Main(){
      Console.WriteLine("Bonjour! Today we sell bread at $5 (buy two, third is free!) and pastries starting at $2");
      Console.WriteLine("=====================================================");
      Console.WriteLine("How many loaves of bread would you like?");
      int custBread = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int custPastry = int.Parse(Console.ReadLine());
      // AssembleOrder()

      
    }

    // public static int AssembleOrder()
    // {
    //   //get bread cost
    //   //get pastry cost
    // }
  }
}