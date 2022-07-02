using System;

namespace Bakery.Models
{
  public class Bread
  {
    //properties
    public int LoavesOfBread {get;}

    //constructor
    public Bread(int loavesOfBread)
    {
      LoavesOfBread = loavesOfBread;
    }

     //public methods
    public void DisplayBreadTotal()
    {
      CostOfBread();
    }

    //private methods
    private int CostOfBread()
    {
      if (LoavesOfBread == 1)
      {
        private int breadTotal = 5;
      } 
    }
    //properties, constructors, methods, etc. 
  }
}