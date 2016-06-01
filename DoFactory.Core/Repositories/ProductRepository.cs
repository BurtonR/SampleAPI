using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DoFactory.Data.Models;

namespace DoFactory.Data.Repositories
{
    public class ProductRepository
    {
        private readonly IDbConnection _connection;
        public ProductRepository()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public Product GetProduct(int productId)
        {
            string sql = $"SELECT * FROM Product WHERE Id = {productId}";

            using (var con = _connection)
            {
                var result = con.Query<Product>(sql).FirstOrDefault(); 
                return result;
            }
        }

        public void SaveProduct(Product product)
        {
            //TODO: Implement save
        }

        public IEnumerable<Product> GetAllProducts()
        {
            const string sql = "SELECT * FROM Product";

            using (var con = _connection)
            {
                return con.Query<Product>(sql);
            }
        }
    }
}
