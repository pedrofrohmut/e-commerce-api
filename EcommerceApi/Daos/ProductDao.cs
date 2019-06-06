using System.Collections.Generic;
using System;
using System.Data;
using MySql.Data.MySqlClient;

using EcommerceApi.Util;
using EcommerceApi.Models;

namespace EcommerceApi.Daos {

  public class ProductDao {

    private readonly MySqlConnection Connection;

    public ProductDao(MySqlConnection connection) {
      this.Connection = connection;
    }

    public List<Product> FindAll() {
      var products = new List<Product>();

      using (this.Connection) {
        this.Connection.Open();

        string query = 
          @" SELECT id, title, img, price, company, info
             FROM ecommerce.product ";
        using (var cmd = new MySqlCommand(query, this.Connection)) {
          using (var reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
              var product = new Product() {
                Id = reader.GetFieldValue<int>(0),
                Title = reader.GetFieldValue<string>(1),
                Img = reader.GetFieldValue<string>(2),
                Price = reader.GetFieldValue<decimal>(3),
                Company = reader.GetFieldValue<string>(4),
                Info = reader.GetFieldValue<string>(5)
              };
              products.Add(product);
            }
          }
        }
      }

      return products;
    } // FindAll


    public Product FindOneById(int id) {
      Product product = null;

      string query =
        @" SELECT id, title, img, price, company, info
           FROM ecommerce.product 
           WHERE id = @id ";
      using (this.Connection) {
        using (var cmd = new MySqlCommand(query, this.Connection)) {
          cmd.Parameters.AddWithValue("@id", id);
          cmd.Connection.Open();
          using (var reader = cmd.ExecuteReader()) {
            if (reader.Read()) {
              product = new Product() {
                Id = reader.GetFieldValue<int>(0),
                Title = reader.GetFieldValue<string>(1),
                Img = reader.GetFieldValue<string>(2),
                Price = reader.GetFieldValue<decimal>(3),
                Company = reader.GetFieldValue<string>(4),
                Info = reader.GetFieldValue<string>(5)
              };
            }
          }
        }
      }

      return product;
    } // FindOneById


    public int Create(Product product) {
      int productId = 0;

      string query = 
        @" INSERT INTO ecommerce.product (title, img, price, company, info)
           VALUES (@title, @img, @price, @company, @info);
           SELECT last_insert_id() ";
      using (this.Connection) {
        using (var cmd = new MySqlCommand(query, this.Connection)) {
          cmd.Parameters.AddWithValue("@title", product.Title);
          cmd.Parameters.AddWithValue("@img", product.Img);
          cmd.Parameters.AddWithValue("@price", product.Price);
          cmd.Parameters.AddWithValue("@company", product.Company);
          cmd.Parameters.AddWithValue("@info", product.Info);
          cmd.Connection.Open();
          productId = Convert.ToInt32(cmd.ExecuteScalar());
        }
      }

      return productId;
    }


  } // class

} // namespace
