namespace Bakery.Models
{
  public class Pastry
  {
    //properties
    public int NumberOfPastries {get;}

    //constructor
    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
    }

    //public methods
    public int DisplayPastryTotal()
    {
      return PastryTotal();
    }

    //private methods
    private int PastryTotal()
    {
      return NumberOfPastries * 2;
    }



    // properties
    // public int LoavesOfBread {get;}

    // constructor
    // public Bread(int loavesOfBread)
    // {
    //   LoavesOfBread = loavesOfBread;
    // }

    // public methods
    // public int DisplayBreadTotal()
    // {
    //   return CostOfBread();
    // }

    // private methods
    // private int CostOfBread()
    // {
    //   return LoavesOfBread * 5 - (LoavesOfBread/3*5);    
    // }
    //properties, constructors, methods, etc. 
  }
}