using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using Dapper;
using DoFactory.Data.Models;
using Newtonsoft.Json;

namespace DoFactory.Data.Repositories
{
    public class CustomerRepository
    {
        private readonly IDbConnection _connection;

        public CustomerRepository()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public Customer GetCustomer(int customerId)
        {
            var sql = $"SELECT * FROM Customer WHERE Id = {customerId}";

            using (var con = _connection)
            {
                return con.Query<Customer>(sql).FirstOrDefault();
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            const string sql = "SELECT * FROM Customer";

            using (var con = _connection)
            {
                return con.Query<Customer>(sql);
            }
        }

        public void SaveCustomer(string customerJson = null)
        {
            var output = JsonConvert.DeserializeObject<Customer>(customerJson);
            string sql = $@"UPDATE Customer 
                        SET FirstName = '{output.FirstName}',
                        LastName = '{output.LastName}',
                        City = '{output.City}',
                        Country = '{output.Country}',
                        Phone = '{output.Phone}'
                        WHERE Id = {output.Id}";

            using (var con = _connection)
            {
                con.Execute(sql);
            }
        }
    }
}