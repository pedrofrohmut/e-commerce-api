using System.Collections.Generic;
using EcommerceApi.Models;

namespace EcommerceApi.Models
{
  public class CartModel
  {
    public int Id { get; set; }
    public List<CartItemModel> Items { get; set; } = new List<CartItemModel>();
  }
}
