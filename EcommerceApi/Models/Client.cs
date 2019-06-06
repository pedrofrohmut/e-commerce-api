using EcommerceApi.Models;

namespace EcommerceApi.Models
{
  public class Client
  {
    public int Id { get; set; }
    public Cart Cart { get; set; } = new Cart();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
  }
}
