using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web.Helpers;


namespace ExternalApi.Request
{
    public class ServiceApiRequest
    {
        private HttpClient _client;

        public ServiceApiRequest()
        {
            _client = new HttpClient();
        }

        public object JSON { get; private set; }

        public async Task<T> GetRequest<T>(string estado = "Sao_Paulo")
        {
            HttpResponseMessage response = await _client.GetAsync("http://worldtimeapi.org/api/timezone/America/" + estado + "/");
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                return  result;
            }
            else
            {
                throw new Exception();
            }

        }
 
    }
}
