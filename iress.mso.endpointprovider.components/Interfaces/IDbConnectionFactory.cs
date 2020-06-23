using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace iress.mso.endpointprovider.components
{
    public interface IDbConnectionFactory
    {
        SqlConnection CreateConnection();
    }
}
