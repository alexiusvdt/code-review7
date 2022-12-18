using System;
using Bakery.Models;

namespace MyProgram {
  public class Program {
    public static void Main(){
      Console.WriteLine();
      Console.WriteLine("Bonjour! Today we sell bread at $5 (buy two, the third is free!) and pastries starting at $2 (every third is half off!)");
      Console.WriteLine("=======================================================================================================================");
      bool finished = false;
      // loop to reset order
      while (finished == false) 
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int custBread = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int custPastry = int.Parse(Console.ReadLine());
        int custTotal = AssembleOrder(custBread, custPastry);
        Console.WriteLine($"Your order for for {custBread} loaves and {custPastry} pastry is ${custTotal}.");
        Console.WriteLine();
        Console.WriteLine("Shall I submit your order (Y) or do you want to modify it (N)? Y/N ");
        string done = Console.ReadLine().ToUpper();
        if (done == "Y")
        {
          finished = true;
          Console.WriteLine("Un moment, s'il vous plait...");
          Console.WriteLine("...");
          Console.WriteLine($"Your final total today for {custBread} loaves and {custPastry} pastry is ${custTotal}, merci!"); 
          Console.WriteLine();  
        }
        else if (!IsValid(done))
        {
          Console.WriteLine("Zut alors... You must enter Y or N only! Try again, mon ami...");
        }
        else 
        {
          Console.WriteLine("Bon, let's clear your order then...");
          Console.WriteLine();
        }
      }
    }

    public static int AssembleOrder(int custBread, int custPastry)
    {
      int orderTotal = (Bread.BreadTotal(custBread) + Pastry.PastryTotal(custPastry));
      return orderTotal;
    }

    public static bool IsValid(string done)
    {
      if (done == "Y" || done == "N")
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}