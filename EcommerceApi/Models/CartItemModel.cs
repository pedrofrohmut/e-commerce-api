using EcommerceApi.Models;

namespace EcommerceApi.Models 
{
  public class CartItemModel
  {
    public int Id { get; set; }
    public ProductModel Product { get; set; } = new ProductModel();
    public int Quantity { get; set; }
  }
}
