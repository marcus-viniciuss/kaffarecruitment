using ExternalApi.Models;
using ExternalApi.Request;
using System.Threading.Tasks;

namespace ExternalApi
{
    public class ServiceApi
    {
        private ServiceApiRequest _serviceApiRequest;
        public ServiceApi()
        {
            _serviceApiRequest = new ServiceApiRequest();
        }

        public async Task<Clock> Get()
        {
                   return await _serviceApiRequest.GetRequest<Clock>();
        }

    }
}
