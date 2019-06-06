using System.Collections.Generic;
using EcommerceApi.Models;

namespace EcommerceApi.Models
{
  public class Cart
  {
    public int Id { get; set; }
    public List<CartItem> Items { get; set; } = new List<CartItem>();
  }
}
