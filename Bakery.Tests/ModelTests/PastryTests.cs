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
      Pastry newPastryOrder = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod] //second test
    public void GetNumberOfPastries_RetrieveHowManyPastriesInInstanceOfPastry_int()
    {
      int numberOfPastriesRequested = 1;
      Pastry newPastryOrder = new Pastry(numberOfPastriesRequested);
      int result = newPastryOrder.NumberOfPastries;
      Assert.AreEqual(numberOfPastriesRequested, result);
    }

    [TestMethod] //third test
    public void DisplayPastryTotal_CalculatesCostOfOnePastry_int()
    {
      int numberOfPastriesRequested = 1;
      Pastry newPastryOrder = new Pastry(numberOfPastriesRequested);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(2, result);
    }

    [TestMethod] // fourth test
    public void DisplayPastryTotal_CalculatesCostOfTwoPastry_int()
    {
      int numberOfPastriesRequested = 2;
      Pastry newPastryOrder = new Pastry(numberOfPastriesRequested);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(4, result);
    }
    

  }
}