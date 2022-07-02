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
      return BreadTotal();
    }

    //private methods
    private int BreadTotal()
    {
      return LoavesOfBread * 5 - (LoavesOfBread/3*5);    
    }
    //properties, constructors, methods, etc. 
  }
} 