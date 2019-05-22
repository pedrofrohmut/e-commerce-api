using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController: ControllerBase
  {
    private readonly List<ProductModel> products = new List<ProductModel>();

    public ProductController() {
      products.Add(new ProductModel() { Id=1, Title="prod1", Img="Img1", Price=123, Company="Company1", Info="Here is the product info" });
      products.Add(new ProductModel() { Id=2, Title="prod2", Img="Img2", Price=223, Company="Company2", Info="Here is the product info" });
      products.Add(new ProductModel() { Id=3, Title="prod3", Img="Img3", Price=323, Company="Company3", Info="Here is the product info" });
      products.Add(new ProductModel() { Id=4, Title="prod4", Img="Img4", Price=423, Company="Company4", Info="Here is the product info" });
    }

    // GET api/product
    [Route("")]
    [HttpGet]
    public ActionResult<List<ProductModel>> GetAllProducts() {
      return this.products;
    }

    // GET api/product/5
    [Route("{id}")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<ProductModel> GetById(int id) {
      ProductModel product = products.Find(p => p.Id == id);
      if (product == null) return BadRequest();
      return product;
    }

    // POST api/product
    [Route("{id}")]
    [HttpPost]
    public void CreateProduct([FromBody] ProductModel product) {
    }

    // PUT api/product/5
    [Route("{id}")]
    [HttpPut]
    public void UpdateProduct(int id, [FromBody] ProductModel product) {
    }

    // DELETE api/product/5
    [Route("{id}")]
    [HttpDelete]
    public void RemoveProduct(int id) {
    }
  }
}
