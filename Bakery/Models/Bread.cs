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
    public int DisplayBreadTotal()
    {
      return CostOfBread();
    }

    //private methods
    private int CostOfBread()
    {
      if (LoavesOfBread == 1)
      {
        return 5;
      } 
      else
      {
        return 0;
      }
      
    }
    //properties, constructors, methods, etc. 
  }
}