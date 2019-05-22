using EcommerceApi.Models;

namespace EcommerceApi.Models
{
  public class ClientModel
  {
    public int Id { get; set; }
    public CartModel Cart { get; set; } = new CartModel();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
  }
}
