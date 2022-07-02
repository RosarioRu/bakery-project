using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod] //first test
    public void PastryConstructor_CreatesAnInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    // [TestMethod] //first test
    // public void BreadConstructor_CreatesAnInstanceOfBread_Bread()
    // {
    //   Bread newBreadOrder = new Bread(1);
    //   Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    // }
    //test methods for pastries go here
  }
}