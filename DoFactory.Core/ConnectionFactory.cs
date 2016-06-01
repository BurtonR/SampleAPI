using System.Data;
using System.Data.SqlClient;

namespace DoFactory.Data
{
    public static class ConnectionFactory
    {
        public static IDbConnection GetConnection()
        {
            var connection = new SqlConnection
            {
                ConnectionString = "Server=LocalDB;Database=doFactory;User Id=doFactoryService;Password = doFactoryService; "
            };
            return connection;
        }
    }
}
