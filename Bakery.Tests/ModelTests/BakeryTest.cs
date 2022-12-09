using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

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
      Assert.AreEqual(50, Bread.BreadTotal(15));
    }
    [TestMethod]
    public void BreadClass_CalculatesSecondDiscount_Bread()
    {
      int custBread = 5;
      Assert.AreEqual(20, Bread.BreadTotal(5));
    }
        [TestMethod]
    public void BreadClass_CalculatesFirstDiscount_Bread()
    {
      int custBread = 4;
      Assert.AreEqual(15, Bread.BreadTotal(4));    }
  }
}