using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using MyProgram;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods will go here, this is just an example
    [TestMethod]
    public void BreadClass_CalculatesThirdDiscount_Bread()
    {
      int custBread = 15;
      Assert.AreEqual(50, Bread.BreadTotal(custBread));
    }
    [TestMethod]
    public void BreadClass_CalculatesSecondDiscount_Bread()
    {
      int custBread = 5;
      Assert.AreEqual(20, Bread.BreadTotal(custBread));
    }
    [TestMethod]
    public void BreadClass_CalculatesFirstDiscount_Bread()
    {
      int custBread = 4;
      Assert.AreEqual(15, Bread.BreadTotal(custBread)); 
    }
    [TestMethod]
    public void BreadClass_CalculatesHighCount_Bread()
    {
      int custBread = 10;
      Assert.AreEqual(35, Bread.BreadTotal(custBread)); 
    }
  }
  
  [TestClass]
  public class PastryTests
  {
    // Test methods will go here, this is just an example
    [TestMethod]
    public void PastryClass_CalculatesdDiscount_Pastry()
    {
      int custPastry = 6;
      Assert.AreEqual(10, Pastry.PastryTotal(custPastry));
    }
    public void PastryClass_DoubleCheckYourLogic_Pastry()
    {
      int custPastry = 300;
      Assert.AreEqual(500, Pastry.PastryTotal(custPastry));
    }
    public void PastryClass_CheckHighPastryCount_Pastry()
    {
      int custPastry = 10;
      Assert.AreEqual(17, Pastry.PastryTotal(custPastry));
    }
  }
  [TestClass]
  public class ProgramTest
  {
    [TestMethod]
    public void  TestAssembleOrder_BreadAndPastry()
    {
    Assert.AreEqual(12, Program.AssembleOrder(1, 4));
    }
    [TestMethod]
    public void  TestAssembleOrder_OnlyBread()
    {
    Assert.AreEqual(10, Program.AssembleOrder(3, 0));
    }
    [TestMethod]
    public void  TestAssembleOrder_OnlyPastry()
    {
    Assert.AreEqual(5, Program.AssembleOrder(0, 3));
    }
    [TestMethod]
    public void  TestAssembleOrder_BreadAndPastry2()
    {
    Assert.AreEqual(0, Program.AssembleOrder(0, 0));
    }
    [TestMethod]
    public void  TestAssembleOrder_BreadAndPastry3()
    {
    Assert.AreEqual(15, Program.AssembleOrder(1, 6));
    }
    [TestMethod]
    public void  TestAssembleOrder_BreadAndPastry4()
    {
    Assert.AreEqual(52, Program.AssembleOrder(10, 10));
    }

    [TestMethod]
    public void TestValidation_Program()
    {
    string done = "Y";
    Assert.AreEqual(true, Program.IsValid(done));
    Assert.AreEqual(true, Program.IsValid("N"));
    }
  }
}