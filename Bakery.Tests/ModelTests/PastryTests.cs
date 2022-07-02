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

    [TestMethod] //fifth test
    public void DisplayPastryTotal_CalculateCostOfThreePastry_int()
    {
      int numberOfPastriesRequested = 3;
      Pastry newPastryOrder = new Pastry(numberOfPastriesRequested);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(5, result);
    }
  

    [TestMethod] // sixth test
    public void DisplayPastryTotal_CalculatesCostOfTenPastry_int()
    {
      Pastry newPastryOrder = new Pastry(10);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(17, result);
    }

    [TestMethod] //seventh test
    public void DisplayPastryTotal_CalculateCostOfZeroPastry_int()
    {
      Pastry newPastryOrder = new Pastry(0);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(0, result);
    }

    [TestMethod] // eigth test
    public void DisplayPastryTotal_CalculateCostOf100Pastry_int()
    {
      Pastry newPastryOrder = new Pastry(100);
      int result = newPastryOrder.DisplayPastryTotal();
      Assert.AreEqual(167, result);
    }
  }
}