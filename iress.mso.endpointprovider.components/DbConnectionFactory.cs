
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace iress.mso.endpointprovider.components
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
