using System;
using MySql.Data.MySqlClient;

namespace EcommerceApi.Util {

  public class AppDb : IDisposable {

    public MySqlConnection Connection;

    public AppDb(string connectionString) {
      this.Connection = new MySqlConnection(connectionString);
    }

    public void Dispose() {
      this.Connection.Close();
    }

  }

}
