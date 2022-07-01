using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesAnInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetLoavesOfBread_DisplaysHowManyLoavesInInstanceOfBread_int()
    { 
      int numberOfLoavesRequested = 4;
      Bread newBreadOrder = new Bread(4);
      int result = newBreadOrder.LoavesOfBread;
      Assert.AreEqual(numberOfLoavesRequested, result);
    }
  }
}