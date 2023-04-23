using System.Collections.Generic;

namespace Pastrys.Models
{
  public class Pastry
  {
    private int _quantity;
    public int Quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    public Pastry(int amount)
    {
      _quantity = amount;
    }

    public string CheckCost()
    {
      int price = (_quantity / 4) * 6;
      if (_quantity % 4 == 0) 
      {
        return price.ToString();
      } 
      else 
      {
        return (price + ((_quantity % 4) * 2)).ToString();
      }
    }
  }
}
