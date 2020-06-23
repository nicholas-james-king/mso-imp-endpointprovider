using iress.mso.endpointprovider.components.Pocos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace iress.mso.endpointprovider.components.Mappers
{
    static internal class DbMapper
    {
        static internal async Task<Endpoint> MapDbEndpointToPoco(SqlDataReader reader) 
        {
            var endpoint = new Endpoint();
            endpoint.Id = await SafeGetDataReaderValue<Guid>(reader, "Id");
            endpoint.Name = await SafeGetDataReaderValue<string>(reader, "Name");
            endpoint.URI = await SafeGetDataReaderValue<string>(reader, "URI");
            endpoint.CreatedDate = await SafeGetDataReaderValue<DateTime>(reader, "CreatedDate");
            endpoint.LastUpdatedDate = await SafeGetDataReaderValue<DateTime>(reader, "LastUpdatedDate");

            return endpoint;
        }
        internal static async Task<T> SafeGetDataReaderValue<T>(IDataRecord record, string columnName)
        {
            var ordinal = record.GetOrdinal(columnName);
            var result = default(T);

            if (!record.IsDBNull(ordinal))
                result = (T)record.GetValue(ordinal);

            return await Task.FromResult(result);
        }
    }
}
