using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DoFactory.Data.Models;

namespace DoFactory.Data.Repositories
{
    public class SupplierRepository
    {
        private readonly IDbConnection _connection;

        public SupplierRepository()
        {
            _connection = ConnectionFactory.GetConnection();
        }

        public Supplier GetSupplier(int suplierId)
        {
            string sql = $"SELECT * FROM Supplier WHERE Id = {suplierId}";

            using (var con = _connection)
            {
                return con.Query<Supplier>(sql).FirstOrDefault();
            }
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            const string sql = "SELECT * FROM Supplier";

            using (var con = _connection)
            {
                return con.Query<Supplier>(sql);
            }
        }

        public void SaveSupplier(Supplier supplier)
        {
            //TODO: Implement save
        }
    }
}