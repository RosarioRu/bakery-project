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
      if (NumberOfPastries % 6 == 0)
      {
        return NumberOfPastries/6*10;
      }
      else
      {
        if (NumberOfPastries % 6 == 5)
        {
          return ((NumberOfPastries/6*10) + (9)); 
        } 
        else if (NumberOfPastries % 6 == 4)
        {
          return ((NumberOfPastries/6*10) + (7));
        }
        else if (NumberOfPastries % 6 == 3)
        {
          return ((NumberOfPastries/6*10) + (5));
        }
        else
        {
          return ((NumberOfPastries/6*10) + (NumberOfPastries % 6 * 2));
        }
      }
    }

  }
}