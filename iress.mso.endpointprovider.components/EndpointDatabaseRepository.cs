using iress.mso.endpointprovider.components.Mappers;
using iress.mso.endpointprovider.components.Pocos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace iress.mso.endpointprovider.components
{
    public class EndpointDatabaseRepository : IEndpointRepository
    {
        private IDbConnectionFactory __dbConnectionFactory { get; set; }
        public EndpointDatabaseRepository(IDbConnectionFactory dbConnectionFactory)
        {
            __dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<Endpoint> GetEndpointAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Please provide a populated string of the name of the endpoint you require");

            using (var conn = __dbConnectionFactory.CreateConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEndpoint";

                //Input parameters
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar) { Value = name });

                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var endpoint = await DbMapper.MapDbEndpointToPoco(reader);

                    return endpoint;
                }
            }
        }
    }
}
