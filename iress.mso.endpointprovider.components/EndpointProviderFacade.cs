using iress.mso.endpointprovider.components.Pocos;
using System;
using System.Threading.Tasks;

namespace iress.mso.endpointprovider.components
{
    public class EndpointProviderFacade : IEndPointProviderFacade
    {
        private IEndpointRepository _repository { get; set; }

        public EndpointProviderFacade(IEndpointRepository repository)
        {
            _repository = repository;
        }
        public async Task<Endpoint> GetEndPointAsync(string name)
        {
            try
            {
                var result = await _repository.GetEndpointAsync(name);

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
