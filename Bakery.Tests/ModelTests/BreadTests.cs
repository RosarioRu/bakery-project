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
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

  }
}