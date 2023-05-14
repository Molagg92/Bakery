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
  }
}