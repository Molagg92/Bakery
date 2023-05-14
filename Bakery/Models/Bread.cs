using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price = 5;
    public int LoafQuantity { get; set; }

    public Bread(int Quantity)
    {
      LoafQuantity = Quantity;
    }

    public int BreadOrder()
    {
      int discountBread = (LoafQuantity / 3) * 2;
      int fullPriceBread = LoafQuantity % 3;
      LoafQuantity = (fullPriceBread + discountBread) * Price;
      return LoafQuantity;
    }
  }
}