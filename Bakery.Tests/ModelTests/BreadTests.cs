using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod] //first test
    public void BreadConstructor_CreatesAnInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod] //second test
    public void GetLoavesOfBread_DisplaysHowManyLoavesInInstanceOfBread_int()
    { 
      int numberOfLoavesRequested = 4;
      Bread newBreadOrder = new Bread(numberOfLoavesRequested);
      int result = newBreadOrder.LoavesOfBread;
      Assert.AreEqual(numberOfLoavesRequested, result);
    }

    [TestMethod] //third test
    public void DisplayBreadTotal_CalculatesCostOfBread_int()
    {
      int numberOfLoavesRequested = 1;
      Bread newBreadOrder = new Bread(numberOfLoavesRequested);
      int result = newBreadOrder.DisplayBreadTotal();
      Assert.AreEqual(5, result);
    }
  }
}