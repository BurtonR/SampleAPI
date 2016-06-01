using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DoFactory.Data.Models;

namespace DoFactory.Data.Repositories
{
    public class OrderRepository
    {
        private readonly IDbConnection _connection;

        public OrderRepository()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public Order GetOrder(int orderId)
        {
            var sql = $"SELECT * FROM [Order] WHERE Id = {orderId}";

            using (var con = _connection)
            {
                return con.Query<Order>(sql).FirstOrDefault();
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            const string sql = "SELECT * FROM [Order]";

            using (var con = _connection)
            {
                return con.Query<Order>(sql);
            }
        }

        public void SaveOrder()
        {
            //TODO: Implement save
        }
    }
}