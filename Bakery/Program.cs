using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static int requestedLoaves;
    public static int requestedPastries;

    public static void Main()
    {
      Console.WriteLine(" ");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY!");
      Console.WriteLine("Today's daily loaf is our Seeded Sourdough. For pastry we have Pistachio Croissant.");
      Console.WriteLine("----------------------------------------------");
      Console.WriteLine("Seeded Sourdough: $5/loaf. Buy 2, get 1 free!");
      Console.WriteLine("Pistachio Croissant: 1 for $2, 3 for $5, 4 for $7, 5 for $9, and a half dozen for $10");
      Console.WriteLine("----------------------------------------------");

      GetBreadTotal();
      GetPastryTotal();
      CalculateOrderTotal();
    }

    private static void GetBreadTotal()
    {
      Console.WriteLine("How Many loaves of bread would you like to order?");
      string breadAnswer = Console.ReadLine();
      bool checkBreadAnswer = int.TryParse(breadAnswer, out requestedLoaves);
      if (checkBreadAnswer == false)
      {
        Console.WriteLine("Please re-enter your answer as a number.");
        GetBreadTotal();
      }
    }

    private static void GetPastryTotal()
    {
      Console.WriteLine("How many croissants would you like to order?");
      string pastryAnswer = Console.ReadLine();
      bool checkPastryAnser = int.TryParse(pastryAnswer, out requestedPastries);
      if (checkPastryAnser == false)
      {
        Console.WriteLine("Please re-enter your answer as a number.");
        GetPastryTotal();
      }
    }

    private static void CalculateOrderTotal()
    {
      Console.WriteLine(" ");
      Console.WriteLine("You have requested " + requestedLoaves + " loaves of bread and " + requestedPastries + " croissants."); 
      Bread breadOrder = new Bread(requestedLoaves);
      Pastry pastryOrder = new Pastry(requestedPastries);
      int toalCostOfBread = breadOrder.DisplayBreadTotal();
      int totalCostOfPastry = pastryOrder.DisplayPastryTotal();
      int orderTotal = toalCostOfBread + totalCostOfPastry;
      Console.WriteLine("Your total is " + "$" + orderTotal + ".");
    }

  }
}