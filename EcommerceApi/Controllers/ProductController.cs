using Microsoft.AspNetCore.Mvc;
/* using Microsoft.AspNetCore.Http; // HttpMessages */
using System.Collections.Generic;

using EcommerceApi.Models;
using EcommerceApi.Daos;
using EcommerceApi.Util;

namespace EcommerceApi.Controllers {

  [Route("api/[controller]")]
  [ApiController]
  public class ProductController: ControllerBase {
    
    private readonly AppDb Db;

    public ProductController(AppDb db) {
      this.Db = db;
    }

    // GET api/product
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAllProducts() {
      var dao = new ProductDao(this.Db.Connection);
      var products = dao.FindAll();
      return Ok(products);
    }

    // GET api/product/{id}
    [HttpGet("{id}")]
    public ActionResult<Product> GetOneProduct(int id) {
      var dao = new ProductDao(this.Db.Connection);
      var product = dao.FindOneById(id);
      if (product == null) {
        return BadRequest();
      }
      return Ok(product);
    }

    // POST api/product
    [HttpPost]
    public ActionResult<Product> PostProduct([FromBody] Product product) {
      var dao = new ProductDao(this.Db.Connection);
      var productId = dao.Create(product);
      return CreatedAtAction("GetOneProduct", 
          new Product() { Id = productId }, product);
    }

    /* // POST api/product */
    /* [Route("{id}")] */
    /* [HttpPost] */
    /* public void CreateProduct([FromBody] ProductModel product) { */
    /* } */

    /* // PUT api/product/5 */
    /* [Route("{id}")] */
    /* [HttpPut] */
    /* public void UpdateProduct(int id, [FromBody] ProductModel product) { */
    /* } */

    /* // DELETE api/product/5 */
    /* [Route("{id}")] */
    /* [HttpDelete] */
    /* public void RemoveProduct(int id) { */
    /* } */
  }
}
