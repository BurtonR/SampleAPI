using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DoFactory.Data.Models;

namespace DoFactory.Data.Repositories
{
    public class OrderItemRepository
    {
        private readonly IDbConnection _connection;

        public OrderItemRepository()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public OrderItem GetOrderItem(int orderItemId)
        {
            var sql = $"SELECT * FROM OrderItem WHERE Id = {orderItemId}";

            using (var con = _connection)
            {
                return con.Query<OrderItem>(sql).FirstOrDefault();
            }
        }

        public IEnumerable<OrderItem> GetOrderItemsByOrder(int orderId)
        {
            var sql = $"SELECT * FROM OrderItem WHERE OrderId = {orderId}";

            using (var con = _connection)
            {
                return con.Query<OrderItem>(sql);
            }
        }

        public IEnumerable<OrderItem> GetOrderItemsByProduct(int productId)
        {
            var sql = $"SELECT * FROM OrderItem WHERE ProductId = {productId}";

            using (var con = _connection)
            {
                return con.Query<OrderItem>(sql);
            }
        }

        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            const string sql = "SELECT * FROM OrderItem";

            using (var con = _connection)
            {
                return con.Query<OrderItem>(sql);
            }
        }

        public void SaveOrder()
        {
            //TODO: Implement save
        }
    }
}