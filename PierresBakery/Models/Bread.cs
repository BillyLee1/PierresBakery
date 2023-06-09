using System.Collections.Generic;

namespace Breads.Models
{
  public class Bread
  {
    private int _quantity;
    public int Quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    public Bread(int amount)
    {
      _quantity = amount;
    }

    public string CheckCost()
    {
      int price = (_quantity / 3) * 10;
      if (_quantity % 3 == 0) 
      {
        return price.ToString();
      } 
      else 
      {
        return (price + ((_quantity % 3) * 5)).ToString();
      }
    }
  }
}
