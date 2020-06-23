using iress.mso.endpointprovider.components.Pocos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iress.mso.endpointprovider.components
{
    public interface IEndPointProviderFacade
    {
        Task<Endpoint> GetEndPointAsync(string name);
    }
}
